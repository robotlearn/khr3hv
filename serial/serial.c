/**
 * Unix (termios API) serial functions example
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

#include "serial.h"

int kondo_serial_open(int *fd, char* port)
{
	// Open the serial port.
	// O_RDWR   : open for read/write
	// O_NOCTTY : do not cause terminal device to be controlling terminal
	// O_NDELAY : program ignores DCD line (else program sleeps until DCD)
	int fd_tmp = open(port, O_RDWR | O_NOCTTY | O_NDELAY);
	if (fd_tmp < 0) {
		fprintf(stderr, "kondo_serial_open: Cannot open %s - %s\n", port, strerror(
				errno));
		return fd_tmp;
	}
	// Configure file reading.
	// F_SETFL : set file status flags.
	*fd = fd_tmp;
	fcntl(*fd, F_SETFL, 0);
	return 0;
}

int kondo_serial_configure(int fd)
{
	struct termios options;
	int result = 0;
	tcgetattr(fd, &options);

	// set baud 115200
	result = cfsetispeed(&options, B115200);
	if (result < 0) {
		fprintf(stderr, "kondo_serial_configure: cfsetispeed() failed - %s\n",
				strerror(errno));
		return result;
	}
	result = cfsetospeed(&options, B115200);
	if (result < 0) {
		fprintf(stderr, "kondo_serial_configure: cfsetospeed() failed - %s\n",
				strerror(errno));
		return result;
	}

	// control options
	// |= CLOCAL : Local connection (no modem control)
	// |= CREAD  : Enable the receiver
	// |= PARENB : Enable parity bit
	// ~PARODD   : Disable odd parity (even parity)
	// ~CSTOPB   : Use 1 stop bit
	// ~CSIZE    : Disable bit mask
	// |= CS8    : 8 bits
	options.c_cflag |= (CLOCAL | CREAD);
	options.c_cflag |= PARENB;
	options.c_cflag &= ~PARODD;
	options.c_cflag &= ~CSTOPB;
	options.c_cflag &= ~CSIZE;
	options.c_cflag |= CS8;

	// line options
	// ~ICANON : disable canonical mode (special chars EOF, EOL, etc)
	// ~ECHO   : echo off
	// ~ISIG   : disable signal handling (e.g. on INTR, QUIT, etc)
	options.c_lflag &= ~(ICANON | ECHO | ISIG);

	// output options (raw output, disable processing)
	options.c_oflag = 0;

	// input options
	// IGNPAR : ignore framing / parity errors
	// IGNBRK : ignore BREAK condition on input
	options.c_iflag = 0;
	options.c_iflag &= ~(IXON | IXOFF | IXANY);
	options.c_iflag |= (IGNPAR | IGNBRK);

	// flush serial port
	result = tcflush(fd, TCIOFLUSH);
	if (result < 0) {
		fprintf(stderr, "kondo_serial_configure: first tcflush() failed - %s\n",
				strerror(errno));
		return result;
	}
	// set attributes for serial port
	result = tcsetattr(fd, TCSANOW, &options);
	if (result < 0) {
		fprintf(stderr, "kondo_serial_configure: tcsetattr() failed - %s\n",
				strerror(errno));
		return result;
	}
	// flush serial port again
	result = tcflush(fd, TCIOFLUSH);
	if (result < 0) {
		fprintf(stderr, "kondo_serial_configure: second tcflush() failed - %s\n",
				strerror(errno));
		return result;
	}
	return 0;
}

int kondo_serial_write(int fd, unsigned char * buf, int n)
{
	return (int) write(fd, buf, n);
}

int kondo_serial_read_timeout(int fd, unsigned char * buf, unsigned int n,
		unsigned long secs, unsigned long usecs)
{
	// set up fd
	fd_set set;
	FD_ZERO(&set);
	FD_SET(fd,&set);

	// set up timeout
	struct timeval timeout;
	timeout.tv_sec = secs;
	timeout.tv_usec = usecs;

	// block for at most usecs for a byte to come in
	int r = select(FD_SETSIZE, &set, NULL, NULL, &timeout);
	if (r <= 0)
		return r;

	// now, finally, do the read.
	return (int) read(fd, buf, n);
}
