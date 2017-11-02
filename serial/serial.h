/**
 * Unix (termios API) serial functions example (header)
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

#ifndef KONDO_SERIAL_H_
#define KONDO_SERIAL_H_

#include <unistd.h>
#include <stdlib.h>
#include <fcntl.h>
#include <stdio.h>
#include <errno.h>
#include <string.h>
#include <termios.h>
#include <ctype.h>
#include <sys/time.h>
#include <sys/stat.h>
#include <sys/types.h>

int kondo_serial_open(int *fd, char* port);
int kondo_serial_configure(int fd);
int kondo_serial_write(int fd, unsigned char * buf, int n);
int kondo_serial_read_timeout(int fd, unsigned char * buf, unsigned int n,
		unsigned long secs, unsigned long usecs);

#endif /* KONDO_SERIAL_H_ */
