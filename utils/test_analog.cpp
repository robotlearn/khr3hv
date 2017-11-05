/**
 * test_analog
 * Example to read and print an analog value (AD1)
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
	// open -------------------------------------------------------------------
	int ret = kondo_init(&ki);
	if (ret < 0) {
		printf("%s", ki.error);
		exit(-1);
	}
	//ki.debug = 1;

	// read analog AD1 ---------------------------------------------------------
	UINT port = 1; // the port to read
	int result = 0; // where the result will be stored

	int i=0;
	for (i=0; i < 1000; i++) { 
	if ((ret = kondo_read_analog(&ki, &result, port)) < 0) {
		printf("%s", ki.error);
		exit(-1);
	}
	printf("Analog value of AD1: %d\n", result);
}

	// close ------------------------------------------------------------------
	ret = kondo_close(&ki);
	if (ret < 0)
		printf("%s", ki.error);

	return 0;
}
