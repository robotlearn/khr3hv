/**
 * test_ics
 * Example for how to control a servo using direct ICS 3.0 protocol.
 * This example does NOT use the RCB-4, you will need to connect servo directly
 * to your FTDI adapter using a half-duplex serial circuit.
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

#include "ics.h"
#include <unistd.h>
#include <math.h>

int main(int argc, char * argv[])
{
	ICSData r;

	if (ics_init(&r) < 0)
		fprintf(stderr, "Could not init: %s\n", r.error);

	// CONSTANT RATE ------------------------------------------------------------
	// distance of motion
	int start = 5000, end = 10000;
	// number of frames to run motion
	int time = 100;
	// how much to move servo at each frame
	int rate = abs(end - start) / time;
	int i;
	for (i = start; i <= end; i += rate) {
		ics_pos(&r, 6, i);
		usleep(14200);
	}

	// SINE WAVE ----------------------------------------------------------------
	start = 10000;
	end = 5000;
	int dur = end - start;
	double m = dur / time;
	int x, y;
	for (x = 0; x < time; x++) {
		y = (5000.0 * cos(x / 64.0 + M_PI / 2.0)) + 10000.0;
		ics_pos(&r, 6, y);
		usleep(14200);
	}

	ics_close(&r);
}
