/**
 * run_motion
 * Example program to run a motion from the RCB-4
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

#include "rcb4.h"
#include <unistd.h>

KondoInstance ki;

int main(int argc, char *argv[])
{
	// check cmd-line arguments -----------------------------------------------
	if (argc < 2) {
		fprintf(stderr, "Usage: run_motion [slot #]\n");
		exit(1);
	}

	// open -------------------------------------------------------------------
	int ret = kondo_init(&ki);
	if (ret < 0) {
		printf("%s", ki.error);
		exit(-1);
	}
	printf("Finish kondo_init.\n");
	ki.debug = 0;

	// play motion ------------------------------------------------------------
	//
	// it waits for at most max_wait (50 seconds) for the motion to finish,
	// and returns immediately when either 50 seconds has passed, or
	// the motion has finished.
	//
	// if you want this function to return immediately,
	// just pass in 0 for max_wait.
	//

	printf("Start to move.\n");
	int joint_num = atoi(argv[1]);

	int i=0;
//	while(i<30){
//		ret = kondo_play_motion(&ki, i, max_wait);
//		printf("ret  %d %d\n", i,ret);
//		i++;
//	}
	ret = kondo_move(&ki, joint_num);
	if (ret < 0) {
		printf("%s", ki.error);
		exit(-1);
	}

	// close ------------------------------------------------------------------
	ret = kondo_close(&ki);
	if (ret < 0)
		printf("%s", ki.error);

	return 0;
}