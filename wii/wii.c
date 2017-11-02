/**
 * Nintendo Wiimote-control demo.
 * Requires libwiiuse installed: http://wiiuse.sourceforge.net
 *
 * Copyright 2010 - Christopher Vo (cvo1@cs.gmu.edu)
 * George Mason University - Autonomous Robotics Laboratory
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#include <stdio.h>
#include <stdlib.h>
#include <wiiuse.h>
#include <rcb4.h>

// motion numbers
#define MOT_HOME 1
#define MOT_ONE 30 
#define MOT_ONE_B 28
#define MOT_TWO 31
#define MOT_TWO_B 27
#define MOT_MINUS 0
#define MOT_PLUS 4
#define MOT_A 17
#define MOT_CALIBRATE 49
#define MOT_FREE 2 
#define MOT_HOLD 3

KondoInstance ki;

void clear_buttons()
{
	kondo_krc3_buttons(&ki, 0, 0, 0, 0, 0);
}

void play_motion(int m)
{
	clear_buttons();
	printf("playing motion %d\n", m);
	kondo_play_motion(&ki, m, 0);
}

void handle_event(struct wiimote_t* wm)
{
	static int freed = 0;

	// b pressed?
	int b_pressed = 0;
	if (IS_PRESSED(wm, WIIMOTE_BUTTON_B))
		b_pressed = 1;

	// basic motion mapping
	if (!b_pressed) {
		if (IS_JUST_PRESSED(wm, WIIMOTE_BUTTON_HOME))
			play_motion(MOT_HOME);
		if (IS_JUST_PRESSED(wm, WIIMOTE_BUTTON_ONE))
			play_motion(MOT_ONE);
		if (IS_JUST_PRESSED(wm, WIIMOTE_BUTTON_TWO))
			play_motion(MOT_TWO);
		if (IS_JUST_PRESSED(wm, WIIMOTE_BUTTON_MINUS))
			play_motion(MOT_MINUS);
		if (IS_JUST_PRESSED(wm, WIIMOTE_BUTTON_PLUS))
			play_motion(MOT_PLUS);
		if (IS_JUST_PRESSED(wm, WIIMOTE_BUTTON_A))
			play_motion(MOT_A);
	} else {
		if (IS_JUST_PRESSED(wm, WIIMOTE_BUTTON_HOME))
			play_motion(MOT_CALIBRATE);
		if (IS_PRESSED(wm, WIIMOTE_BUTTON_ONE) && IS_JUST_PRESSED(wm, WIIMOTE_BUTTON_TWO))
			play_motion(5);
	}

	// A-1: freeze and unfreeze robot
	if (IS_PRESSED(wm, WIIMOTE_BUTTON_A)) {
		if (IS_JUST_PRESSED(wm, WIIMOTE_BUTTON_ONE)) {
			if (freed) {
				play_motion(MOT_HOLD);
				freed = 0;
			} else {
				play_motion(MOT_FREE);
				freed = 1;
			}
		}
	}

	// direction keys
	int su = IS_PRESSED(wm, WIIMOTE_BUTTON_UP);
	int sd = IS_PRESSED(wm, WIIMOTE_BUTTON_DOWN);
	int sl = IS_PRESSED(wm, WIIMOTE_BUTTON_LEFT);
	int sr = IS_PRESSED(wm, WIIMOTE_BUTTON_RIGHT);
	unsigned int button_state = 0;
	if (su)
		button_state |= RCB4_BTN_LU; // up: left stick up
	if (sd)
		button_state |= RCB4_BTN_LD; // down: left stick down
	if (sl && !b_pressed)
		button_state |= RCB4_BTN_LL; // left: left stick left
	if (sr && !b_pressed)
		button_state |= RCB4_BTN_LR; // right: left stick right
	if (sl && b_pressed)
		button_state |= RCB4_BTN_RL; // b-left: right stick left
	if (sr && b_pressed)
		button_state |= RCB4_BTN_RR; // b-right: right stick right

	// set the button state
	kondo_krc3_buttons(&ki, button_state, 0, 0, 0, 0);
}

int main(int argc, char** argv)
{
	wiimote** wiimotes;
	int found, connected;

	// init
	printf("[INFO] Looking for wiimotes (5 seconds)...\n");
	wiimotes = wiiuse_init(1);

	// find wii (wait for 5 seconds)
	found = wiiuse_find(wiimotes, 1, 5);
	if (!found) {
		printf("[INFO] No wiimotes found.\n");
		goto CLEANUP_WIIUSE;
	}

	// connect
	connected = wiiuse_connect(wiimotes, 1);
	if (connected)
		printf("[INFO] Connected to %i wiimotes (of %i found).\n", connected,
				found);
	else {
		printf("[ERROR] Failed to connect to any wiimote.\n");
		goto CLEANUP_WIIUSE;
	}

	// rumble and set leds
	wiiuse_set_leds(wiimotes[0], WIIMOTE_LED_1);
	wiiuse_rumble(wiimotes[0], 1);
	usleep(200000);
	wiiuse_rumble(wiimotes[0], 0);

	// set up kondo
	int ret = kondo_init(&ki);
	if (ret < 0) {
		printf("%s", ki.error);
		goto CLEANUP_AND_EXIT;
	}

	// continuously poll wiimote and handle events
	while (1) {
		if (wiiuse_poll(wiimotes, 1)) {
			switch (wiimotes[0]->event) {
			case WIIUSE_EVENT:
				handle_event(wiimotes[0]);
				break;
			case WIIUSE_DISCONNECT:
			case WIIUSE_UNEXPECTED_DISCONNECT:
				goto CLEANUP_AND_EXIT;
				break;
			default:
				break;
			}
		}
	}

	CLEANUP_AND_EXIT: // clean up kondo and then wiiuse
	ret = kondo_close(&ki);
	if (ret < 0)
		printf("%s", ki.error);

	CLEANUP_WIIUSE: // cleanup just wiiuse
	wiiuse_cleanup(wiimotes, 1);

	return 0;
}
