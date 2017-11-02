/**
 * Kondo ICS 3.0 Library (Header)
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

#ifndef ICS_H_
#define ICS_H_

#include <stdio.h>
#include <assert.h>
#include <string.h>
#include <sys/time.h>
#include "ftdi.h"

// some options
#define ICS_BAUD 115200
#define ICS_USB_VID 0x0403
#define ICS_USB_PID 0x6011
#define ICS_RX_TIMEOUT 1000000
#define ICS_POS_TIMEOUT 300
#define ICS_GET_TIMEOUT 300
#define ICS_SET_TIMEOUT 300
#define ICS_ID_TIMEOUT 300

// ics commands
#define ICS_CMD_POS 0x80
#define ICS_CMD_GET 0xA0
#define ICS_CMD_SET 0xC0
#define ICS_CMD_ID 0xE0
#define ICS_SC_EEPROM  0
#define ICS_SC_STRETCH 1
#define ICS_SC_SPEED   2
#define ICS_SC_CURRENT 3
#define ICS_SC_READ 0
#define ICS_SC_WRITE 1

#ifndef __UCHAR__
#define __UCHAR__
typedef unsigned char UCHAR;
#endif 

#ifndef __UINT__
#define __UINT__
typedef unsigned int UINT;
#endif

// instance data for kondo library
typedef struct
{
	struct ftdi_context ftdic; // ftdi context
	UCHAR swap[128]; // swap space output
	char error[128]; // error messages
	UCHAR debug; // whether to print debug info
} ICSData;

// low level comms
int ics_init(ICSData * r);
int ics_close(ICSData * r);
int ics_write(ICSData * r, int n);
int ics_read(ICSData * r, int n);
int ics_read_timeout(ICSData * r, int n, long timeout);
int ics_purge(ICSData * r);
int ics_trx(ICSData * r, UINT bytes_out, UINT bytes_in);
int ics_trx_timeout(ICSData * r, UINT bytes_out, UINT bytes_in, long timeout);

// position commands
int ics_pos(ICSData * r, UINT id, UINT pos);
int ics_hold(ICSData * r, UINT id);
int ics_free(ICSData * r, UINT id);

// servo setting commands
int ics_get_stretch(ICSData * r, UINT id);
int ics_get_speed(ICSData * r, UINT id);
int ics_get_current(ICSData * r, UINT id);
int ics_set_stretch(ICSData * r, UINT id, UCHAR stretch);
int ics_set_speed(ICSData * r, UINT id, UCHAR speed);
int ics_set_current_limit(ICSData * r, UINT id, UCHAR curlim);

// set servo id (for use when 1 servo is connected)
int ics_get_id(ICSData * r);
int ics_set_id(ICSData * r, UINT id);

// low level commands (be careful!)
//int ics_get_eeprom(ICSData * r, UCHAR ** dest);
//int ics_set_eeprom(ICSData * r, UCHAR ** eeprom);
//int ics_get_mem_bytes(ICSData * r, UCHAR addr, UCHAR num_bytes, UCHAR ** dst);
//int ics_set_mem_bytes(ICSData * r, UCHAR addr, UCHAR num_bytes, UCHAR ** src);

#endif /* ICS_H_ */
