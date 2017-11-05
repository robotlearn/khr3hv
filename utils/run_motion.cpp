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

#include "kondo.h"



kondo ki;

int main(int argc, char *argv[])
{
    // check cmd-line arguments -----------------------------------------------
    if (argc < 2) {
        fprintf(stderr, "Usage: run_motion [slot #]\n");
        exit(1);
    }

    // open -------------------------------------------------------------------
    int ret = ki.kondo_init();
    if (ret < 0) {
        exit(-1);
    }

    // move one joint ---------------------------------------------------------
    printf("Start to move.\n");
    int joint_num = atoi(argv[1]);
    ret = ki.kondo_move(joint_num);
    if (ret < 0) {
        exit(-1);
    }

	// close ------------------------------------------------------------------
	ret = ki.kondo_close();
    if (ret < 0) {
        exit(-1);
    }

	return 0;
}
