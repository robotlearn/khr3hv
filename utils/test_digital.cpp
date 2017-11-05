/**
 * test_digital
 * Example to read digital PIO values
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

void error(KondoRef ki) {
	if(ki) {
		printf("%s", ki->error);
		kondo_close(ki);	
	}
	exit(-1);
}

int main(int argc, char *argv[])
{
	// open -------------------------------------------------------------------
	int ret = kondo_init(&ki);
	if (ret < 0) {
		printf("%s", ki.error);
		exit(-1);	
	}
	//ki.debug = 1;

	// set digital direction to input ------------------------------------------
	int result = 0; // where the result will be stored
	printf("setting direction to input for all PIOs...\n");
	ret = kondo_set_pio_direction(&ki, 0);
	if(ret < 0)
		error(&ki);

	// read digital -----------------------------------------------------------
	int i=0;
	for (i=0; i < 1000; i++) { 
		ret = kondo_read_pio(&ki, &result);
		if(ret < 0) 
			error(&ki);
		printf("digital values: %x\n", result);
		usleep(1000000);
	}

	// close ------------------------------------------------------------------
	ret = kondo_close(&ki);
	if (ret < 0)
		error(&ki);

	return 0;
}
