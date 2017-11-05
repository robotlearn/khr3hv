/**
 * Kondo RCB-4 Library
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

/*------------------------------------------------------------------------------
 * Convenience Macros
 */
#define kondo_error(ki, err) { \
  snprintf(ki->error, 128, "ERROR: %s: %s\n", __func__, err); \
  return -1; }
#define kondo_ftdi_error(ki) { \
  snprintf(ki->error, 128, "ERROR: %s: %s\n", __func__, \
    ftdi_get_error_string(&ki->ftdic)); \
  return -1; }

/*------------------------------------------------------------------------------
 * Open / Initialize the KondoInstance
 * Uses default parameters for baud, vid, and pid.
 * This consists mainly of initializing and opening the USB adapter.
 * Returns 0 if successful, error code otherwise.
 */
int kondo_init(KondoRef ki)
{
	return kondo_init_custom(ki, RCB4_BAUD, RCB4_USB_VID, RCB4_USB_PID,
			INTERFACE_ANY);
}

/*-----------------------------------------------------------------------------
 * Open / Initialize the KondoInstance
 * Accepts baud rate, vid, pid, and interface arguments 
 * This consists mainly of initializing and opening the USB adapter.
 * baud: the baud rate - e.g. 115200
 * vid: the USB vendor ID. See rcb4.h for some examples. 
 * pid: the USB product ID. See rcb4.h for some examples.
 * interface: defined in ftdi.h. possible values:
 *   INTERFACE_ANY, INTERFACE_A, INTERFACE_B, INTERFACE_C, INTERFACE_D
 * Returns 0 if successful, error code otherwise.
 */
int kondo_init_custom(KondoRef ki, int baud, int vid, int pid, int interface)
{
	assert(ki);
	int i;
	ki->debug = 0;

	// init usb
	if (ftdi_init(&ki->ftdic) < 0)
		kondo_ftdi_error(ki);

	// select first interface
	if (ftdi_set_interface(&ki->ftdic, interface) < 0)
		kondo_ftdi_error(ki);

	// open usb device
	if (ftdi_usb_open(&ki->ftdic, vid, pid) < 0)
		kondo_ftdi_error(ki);

	// set baud rate
	if (ftdi_set_baudrate(&ki->ftdic, baud) < 0)
		kondo_ftdi_error(ki);

	// set line parameters (8E1)
	if (ftdi_set_line_property(&ki->ftdic, BITS_8, STOP_BIT_1, EVEN) < 0)
		kondo_ftdi_error(ki);

	// ping robot
	if ((i = kondo_ack(ki)) < 0)
		return i;

	// get options
	if ((i = kondo_get_options(ki)) < 0)
		return i;

	return 0;
}

/*-----------------------------------------------------------------------------
 * Close / Deinitialize the KondoInstance.
 * This consists mainly of closing the USB adapter.
 * Returns 0 if successful, < 0 if error
 */
int kondo_close(KondoRef ki)
{
	assert(ki);

	// close usb device
	if (ftdi_usb_close(&ki->ftdic) < 0)
		kondo_ftdi_error(ki);

	// deinit
	ftdi_deinit(&ki->ftdic);

	return 0;
}

/*-----------------------------------------------------------------------------
 * Write n bytes from the swap to the Kondo.
 * Returns >0 number of bytes written, < 0 if error
 */
int kondo_write(KondoRef ki, int n)
{
	assert(ki);
	int i;
	if ((i = ftdi_write_data(&ki->ftdic, ki->swap, n)) < 0)
		kondo_ftdi_error(ki);
	return i;
}

/*-----------------------------------------------------------------------------
 * Read n bytes from the RCB-4. Reads immediately from the serial buffer.
 * See kondo_read_timeout for a version that blocks waiting for the data.
 * Returns < 0: error
 * Returns >= 0: number of bytes read
 */
int kondo_read(KondoRef ki, int n)
{
	assert(ki);
	int i;
	if ((i = ftdi_read_data(&ki->ftdic, ki->swap, n)) < 0)
		kondo_ftdi_error(ki);
	return i;
}

/*-----------------------------------------------------------------------------
 * Read n bytes from the RCB-4, waiting for at most timeout usecs for n bytes.
 * Performs this by continuously polling the serial buffer until either
 * all of the bytes are read or the timeout has been reached.
 * Returns < 0: error
 * Returns >= 0: number of bytes read
 */
int kondo_read_timeout(KondoRef ki, int n, long timeout)
{
	assert(ki);
	static struct timeval tv, end;
	int i = 0, bytes_read = 0;
	gettimeofday(&tv, NULL);
	// determine end time
	end.tv_sec = tv.tv_sec + timeout / RCB4_SECOND;
	end.tv_usec = tv.tv_usec + timeout % RCB4_SECOND;
	if (end.tv_usec > RCB4_SECOND) {
		end.tv_sec += 1;
		end.tv_usec -= RCB4_SECOND;
	}
	// spam the read until data arrives
	do {
		if ((i = ftdi_read_data(&ki->ftdic, ki->swap, n - bytes_read)) < 0)
			kondo_ftdi_error(ki);
		bytes_read += i;
		gettimeofday(&tv, NULL);
	} while (bytes_read < n && (tv.tv_sec < end.tv_sec || tv.tv_usec
			< end.tv_usec));
	return bytes_read;
}

/*-----------------------------------------------------------------------------
 * Purge the TX and RX serial buffers.
 * Returns 0 if successful, < 0 if error
 */
int kondo_purge(KondoRef ki)
{
	assert(ki);
	if (ftdi_usb_purge_buffers(&ki->ftdic) < 0)
		kondo_ftdi_error(ki);
	return 0;
}

/*-----------------------------------------------------------------------------
 * Compute checksum for n bytes (swap[0] to swap[n-1]).
 * Returns checksum value.
 */
UCHAR kondo_checksum(KondoRef ki, int n)
{
	assert(ki);
	int i;
	UINT sum = 0;
	for (i = 0; i < n; i++)
		sum += ki->swap[i];
	return (UCHAR) sum;
}

/*-----------------------------------------------------------------------------
 * Verify checksum for n bytes (swap[0] to swap[n-1]).
 * Returns 0 if correct, < 0 if incorrect
 */
int kondo_verify_checksum(KondoRef ki, int n)
{
	assert(ki);
	int i;
	UINT sum = 0;
	for (i = 0; i < n; i++)
		sum += ki->swap[i];
	return sum == ki->swap[n] ? 0 : -1;
}

/*-----------------------------------------------------------------------------
 * Load the given data (from ASCII hex string) into swap
 * Returns number of bytes read into swap
 */
int kondo_load_asciihex(KondoRef ki, const char * hex)
{
	assert(ki);
	int i, j;
	int len = strlen(hex);

	// copy just the hex characters into a temporary buffer
	char hexstr[len];
	for (i = 0, j = 0; i < len; i++)
		if (isxdigit(hex[i]))
			hexstr[j++] = hex[i];
	hexstr[j] = '\0';
	len = j;
	int bytelen = len / 2;
	char buf[2];

	// clear swap
	for (i = 0; i < RCB4_SWAP_SIZE; i++)
		ki->swap[i] = 0;

	// convert hex chars to bytes
	for (i = 0, j = 0; i < len; i += 2, j++) {
		buf[0] = hexstr[i];
		buf[1] = hexstr[i + 1];
		ki->swap[j] = strtol(buf, NULL, 16);
	}

	return bytelen;
}

/*-----------------------------------------------------------------------------
 * Transaction template: Purge, then send out_bytes, then receive in_bytes
 * Returns < 0: error
 * Returns >= 0: number of bytes read
 */
int kondo_trx(KondoRef ki, int out_bytes, int in_bytes)
{
	assert(ki);
	int i;
	int j;

	if ((i = kondo_purge(ki)) < 0)
		return i;
	if ((i = kondo_write(ki, out_bytes)) < 0)
		return i;

	// debug printing
	if (ki->debug) {
		printf("send %d bytes: ", i);
		for (j = 0; j < i; j++)
			printf("%x ", ki->swap[j]);
		printf("\n");
	}

	i = kondo_read_timeout(ki, in_bytes, RCB4_RX_TIMEOUT);

	// debug printing
	if (ki->debug) {
		printf("recv %d bytes: ", i);
		for (j = 0; j < i; j++)
			printf("%x ", ki->swap[j]);
		printf("\n");
	}

	return i;
}

/*-----------------------------------------------------------------------------
 * ACK: Send a ping to the robot and get a response.
 * Returns < 0: error
 * Returns 0: OK
 */
int kondo_ack(KondoRef ki)
{
	assert(ki);
	int i;

	// command
	ki->swap[0] = 4; // num bytes
	ki->swap[1] = RCB4_CMD_ACK; // ack command
	ki->swap[2] = RCB4_ACK_BYTE; // ack data
	ki->swap[3] = kondo_checksum(ki, 3); // checksum

	// send 4, expect 4 in response
	if ((i = kondo_trx(ki, 4, 4)) < 0)
		return i;

	// verify length of transmission and ack byte
	if (i != 4 || ki->swap[2] != RCB4_ACK_BYTE)
		kondo_error(ki, "Invalid ACK byte from robot.");

	return 0;
}

/*-----------------------------------------------------------------------------
 * Get options from RCB-4
 * Returns < 0: error
 * Returns 0: OK
 */
int kondo_get_options(KondoRef ki)
{
	assert(ki);
	int i;

	// command
	ki->swap[0] = 10; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_RAM_TO_COM; // RAM to COM
	ki->swap[3] = 0; // addr L
	ki->swap[4] = 0; // addr M
	ki->swap[5] = 0; // addr H
	ki->swap[6] = 0; // ram L
	ki->swap[7] = 0; // ram M
	ki->swap[8] = RCB4_OPT_BYTES; // bytes to move
	ki->swap[9] = kondo_checksum(ki, 9); // checksum

	// send 10, expect 5 in response
	if ((i = kondo_trx(ki, 10, 5)) < 0)
		return i;

	// verify response
	if (i != 5 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was not an option packet");

	// everything ok, write to ki
	ki->opt[0] = ki->swap[2];
	ki->opt[1] = ki->swap[3];

	return 0;
}

/*-----------------------------------------------------------------------------
 * Play a motion with given slot number.
 * Blocks (does not return) until timeout time has elapsed or motion is done.
 * So if you want to run a motion without blocking, just use max_wait = 0
 * Returns < 0: Error
 * Returns 0: All good
 */
int kondo_play_motion(KondoRef ki, UINT num, long timeout)
{
	assert(ki);
	int i;
	UCHAR chk;
	UINT mot_addr;

	// This is a 4-stage instruction:
	// 1. Stop current EEPROM program.
	// 2. Call motion script
	// 3. Resume EEPROM program.
	// 4. Check every 50ms to see if the motion is done.

	// (1) Stop current EEPROM program ----------------------------------------
	// To do this you need to disable the EEPROM and write the PGC
	// to memory so that it can be restored later.
	ki->opt[0] &= ~RCB4_OPT_EEPROM; // disable eeprom
	ki->opt[0] &= ~RCB4_OPT_RESP; // turn off servo response
	ki->opt[0] |= RCB4_OPT_SIO; // ensure servos are on
	ki->swap[0] = 19; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_COM_TO_RAM; // com-->ram
	ki->swap[3] = (UCHAR) (RCB4_ADDR_OPT); // option ram L
	ki->swap[4] = (UCHAR) (RCB4_ADDR_OPT >> 8); // option ram M
	ki->swap[5] = (UCHAR) (RCB4_ADDR_OPT >> 16); // option ram H
	ki->swap[6] = ki->opt[0]; // option data
	ki->swap[7] = ki->opt[1]; // option data
	ki->swap[8] = (UCHAR) (RCB4_ADDR_MAIN); // eeprom program main L
	ki->swap[9] = (UCHAR) (RCB4_ADDR_MAIN >> 8); // eeprom program main M
	ki->swap[10] = (UCHAR) (RCB4_ADDR_MAIN >> 16); // eeprom program main H
	ki->swap[11] = 0;
	ki->swap[12] = 0;
	ki->swap[13] = 0;
	ki->swap[14] = 0;
	ki->swap[15] = 0;
	ki->swap[16] = 0;
	ki->swap[17] = 0;
	chk = kondo_checksum(ki, 18);
	ki->swap[18] = chk;

	// send 19 bytes, expect 4 in response
	if ((i = kondo_trx(ki, 19, 4)) < 0)
		return i;

	// verify response checksum
	if (i != 4 || ki->swap[18] != chk)
		kondo_error(ki, "Bad response trying to stop EEPROM.");

	// (2) call motion script -------------------------------------------------
	// You have to compute the motion address (base + num * size) and call it.
	mot_addr = (RCB4_MOT_SIZE * (num - 1)) + RCB4_ADDR_MOT_BASE;
	ki->swap[0] = 7; // num bytes
	ki->swap[1] = RCB4_CMD_CALL; // command
	ki->swap[2] = (UCHAR) (mot_addr); // motion address l
	ki->swap[3] = (UCHAR) (mot_addr >> 8); // motion address m
	ki->swap[4] = (UCHAR) (mot_addr >> 16); // motion addres h
	ki->swap[5] = 0;
	ki->swap[6] = kondo_checksum(ki, 6);

	// send 7 bytes, expect 4 in response
	if ((i = kondo_trx(ki, 7, 4)) < 0)
		return i;

	// verify response (ack)
	if (i != 4 || ki->swap[2] != RCB4_ACK_BYTE)
		kondo_error(ki, "Bad response trying to call the motion.");

	// (3) resume EEPROM ------------------------------------------------------
	ki->opt[0] |= RCB4_OPT_EEPROM; // enable EEPROM
	ki->opt[0] &= ~RCB4_OPT_VEC; // clear vector jump flag
	ki->swap[0] = 9; // num bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_COM_TO_RAM; // com-->ram
	ki->swap[3] = (UCHAR) (RCB4_ADDR_OPT); // option addr L
	ki->swap[4] = (UCHAR) (RCB4_ADDR_OPT >> 8); // option addr M
	ki->swap[5] = (UCHAR) (RCB4_ADDR_OPT >> 16); // option addr H
	ki->swap[6] = ki->opt[0]; // option low byte
	ki->swap[7] = ki->opt[1]; // option high byte
	ki->swap[8] = kondo_checksum(ki, 8); // checksum

	// send 9 bytes, expect 4 in response
	if ((i = kondo_trx(ki, 9, 4)) < 0)
		return i;

	// verify response (ack)
	if (i != 4 || ki->swap[2] != RCB4_ACK_BYTE)
		kondo_error(ki, "Bad response while trying to restart EEPROM.");

	// (4) wait until the motion is done or max time reached ------------------

	// get current time
	static struct timeval tv, end;
	gettimeofday(&tv, NULL);

	// compute end time
	end.tv_sec = tv.tv_sec + timeout / RCB4_SECOND;
	end.tv_usec = tv.tv_usec + timeout % RCB4_SECOND;
	if (end.tv_usec > RCB4_SECOND) {
		end.tv_sec += 1;
		end.tv_usec -= RCB4_SECOND;
	}

	// while end time not exceeded
	while ((tv.tv_sec < end.tv_sec) || (tv.tv_usec < end.tv_usec)) {
		// get the options and check vector jump flag
		if ((i = kondo_get_options(ki)) < 0)
			return i;
		if ((ki->opt[0] & RCB4_OPT_VEC) == RCB4_OPT_VEC)
			break;

		// it takes 50ms to load the option data
		// so wait 50ms here before trying again.
		usleep(RCB4_50MS);

		// check time
		gettimeofday(&tv, NULL);
	}

	return 0;
}

/*-----------------------------------------------------------------------------
 * Stop the currently playing motion, freezing the robot in place.
 * Returns < 0: error
 * Returns 0: all good
 */
int kondo_stop_motion(KondoRef ki)
{
	assert(ki);
	int i;

	// command
	ki->swap[0] = 9; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_COM_TO_RAM; // COM --> RAM
	ki->swap[3] = 0; // addr L
	ki->swap[4] = 0; // addr M
	ki->swap[5] = 0; // addr H
	ki->swap[6] = 0x19; // ram L
	ki->swap[7] = 0x80; // ram M
	ki->swap[9] = kondo_checksum(ki, 8); // checksum

	// send 9, expect 4 in response
	if ((i = kondo_trx(ki, 9, 4)) < 0)
		return i;

	// verify response
	if (i != 4 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was not valid.");

	return 0;
}

/*-----------------------------------------------------------------------------
 * Emulate a KRC-3 button state change
 * See button codes in libkondo_rcb4.h
 * cc: (bit field) the buttons activated, 0 = released, 1 = pressed
 * a1 - a4: analog input 1 - 4
 * Returns: 0 if successful, < 0 if error.
 */
int kondo_krc3_buttons(KondoRef ki, UINT cc, UCHAR a1, UCHAR a2, UCHAR a3,
		UCHAR a4)
{
	assert(ki);
	int i;

	ki->swap[0] = 13;
	ki->swap[1] = RCB4_CMD_MOV;
	ki->swap[2] = RCB4_COM_TO_RAM; // com --> ram
	ki->swap[3] = RCB4_ADDR_BTN_L; // ram L
	ki->swap[4] = RCB4_ADDR_BTN_M; // ram M
	ki->swap[5] = RCB4_ADDR_BTN_H; // ram H
	ki->swap[6] = (UCHAR) (cc >> 8); // btn1
	ki->swap[7] = (UCHAR) (cc); // btn2
	ki->swap[8] = a1;
	ki->swap[9] = a2;
	ki->swap[10] = a3;
	ki->swap[11] = a4;
	ki->swap[12] = kondo_checksum(ki, 12);

	// send 13 bytes, expect 4 in response
	if ((i = kondo_trx(ki, 13, 4)) < 0)
		return i;

	// verify response checksum
	if (i != 4 || ki->swap[2] != RCB4_ACK_BYTE)
		kondo_error(ki, "Bad response trying emulate KRC3 keypress.");

	return 0;
}

/*-----------------------------------------------------------------------------
 * Read an analog value (Battery, AD1, AD2, AD3, etc)
 * Analog number 0 is the battery voltage.
 * Analog numbers 1-11 are the analog inputs.
 * Side effect: The analog value is read into 'result'.
 * Returns: 0 if successful, < 0 if error.
 */
int kondo_read_analog(KondoRef ki, int * result, UINT num)
{
	assert(ki);
	int i;

	// check port number range
	if (num < 0 || num > 10)
		kondo_error(ki, "Invalid analog port number");

	// the memory locations of the requested analog values
	int mem_h = RCB4_ADDR_AD_READ_BASE + (num * 2);
	int mem_l = RCB4_ADDR_AD_REF_BASE + (num * 2);
	int mem_h_val = 0, mem_l_val = 0;

	// build command to read mem_h from RAM to COM
	ki->swap[0] = 10; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_RAM_TO_COM; // RAM to COM
	ki->swap[3] = 0; // dest addr L (0 for COM)
	ki->swap[4] = 0; // dest addr M (0 for COM)
	ki->swap[5] = 0; // dest addr H (0 for COM)
	ki->swap[6] = (UCHAR) (mem_h); // mem_h low byte
	ki->swap[7] = (UCHAR) (mem_h >> 8); // mem_h high byte
	ki->swap[8] = 2; // bytes to move
	ki->swap[9] = kondo_checksum(ki, 9); // checksum

	// send 10, expect 5 in response
	if ((i = kondo_trx(ki, 10, 5)) < 0)
		return i;

	// verify response
	if (i != 5 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was not analog values");

	// decode mem_h value (which might be negative)
	mem_h_val = ((mem_h_val | ki->swap[3]) << 8) | ki->swap[2];
	if (mem_h_val > 0x8000)
		mem_h_val = -(~mem_h_val & 0x7fff) - 1;

	// build command to read mem_l from RAM to COM
	ki->swap[0] = 10; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_RAM_TO_COM; // RAM to COM
	ki->swap[3] = 0; // dest addr L (0 for COM)
	ki->swap[4] = 0; // dest addr M (0 for COM)
	ki->swap[5] = 0; // dest addr H (0 for COM)
	ki->swap[6] = (UCHAR) (mem_l); // mem_h low byte
	ki->swap[7] = (UCHAR) (mem_l >> 8); // mem_h high byte
	ki->swap[8] = 2; // bytes to move
	ki->swap[9] = kondo_checksum(ki, 9); // checksum

	// send 10, expect 5 in response
	if ((i = kondo_trx(ki, 10, 5)) < 0)
		return i;

	// verify response
	if (i != 5 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was not analog values");

	// decode mem_l value (which might be negative)
	mem_l_val = ((mem_l_val | ki->swap[3]) << 8) | ki->swap[2];
	if (mem_l_val > 0x8000)
		mem_l_val = -(~mem_l_val & 0x7fff) - 1;

	// save result
	if (result)
		*result = mem_h_val + mem_l_val;

	return 0;
}

/*-----------------------------------------------------------------------------
 * Read digital values (PIO1 to PIO10)
 * The 'result' will be set to a 10-bit field of the digital values.
 * The format of result will be 10-bits, lowest order bit is the value of PIO1
 * Returns: 0 if successful, < 0 if error.
 */
int kondo_read_pio(KondoRef ki, UINT * result)
{
	assert(ki);
	int i;

	// build command to read mem_h from RAM to COM
	ki->swap[0] = 10; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_RAM_TO_COM; // RAM to COM
	ki->swap[3] = 0; // dest addr L (0 for COM)
	ki->swap[4] = 0; // dest addr M (0 for COM)
	ki->swap[5] = 0; // dest addr H (0 for COM)
	ki->swap[6] = (UCHAR) (RCB4_ADDR_PIO_OUTPUT); // mem_h low byte
	ki->swap[7] = (UCHAR) (0); // mem_h high byte
	ki->swap[8] = 2; // bytes to move
	ki->swap[9] = kondo_checksum(ki, 9); // checksum

	// send 10, expect 5 in response
	if ((i = kondo_trx(ki, 10, 5)) < 0)
		return i;

	// verify response
	if (i != 5 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was not digital values");

	// save result
	if (result)
		*result = (((UINT) (ki->swap[3]) << 8) | ki->swap[2]) & 0x2F;

	return 0;
}

/*-----------------------------------------------------------------------------
 * Set the direction for the digital (PIO) ports.
 * bitfield: 9-bits where 1=Output, 0=Input. PIO1 is bit 0 ~ PIO10 is bit 9.
 * NOTE: At power-on, the PIO direction defaults to 1 (Output) for all ports.
 * See kondo_get_pio_direction to get direction (input / output) of the ports.
 * Returns: 0 if successful, < 0 if error.
 */
int kondo_set_pio_direction(KondoRef ki, UINT bitfield)
{
	assert(ki);
	int i;

	// mask bitfield
	bitfield = bitfield & 0x2F;

	// build command to send val into the counter
	ki->swap[0] = 10; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_COM_TO_RAM; // COM to RAM
	ki->swap[3] = (UCHAR) (RCB4_ADDR_PIO_SET); // dest addr L
	ki->swap[4] = 0; // dest addr H
	ki->swap[5] = 0; // 0 for RAM destination
	ki->swap[6] = (UCHAR) (bitfield); // value to send
	ki->swap[7] = (UCHAR) (bitfield >> 8);
	ki->swap[8] = 2; // bytes to move
	ki->swap[9] = kondo_checksum(ki, 9); // checksum

	// send 10, expect 4 in response
	if ((i = kondo_trx(ki, 10, 4)) < 0)
		return i;
	
	// verify response
	if (i != 4 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was not valid");

	return 0;
}

/*-----------------------------------------------------------------------------
 * Get the direction for the digital ports.
 * Side effect: The direction for all the ports will be returned in bitfield.
 * The format of result is a 9-bits field, lowest order bit is the value of
 * PIO1; 1=Output, 0=Input
 * NOTE: At power-on, the PIO direction defaults to 1 (Output) for all ports.
 * See kondo_set_pio_direction() to set the direction of the PIO ports.
 * Returns: 0 if successful, < 0 if error.
 */
int kondo_get_pio_direction(KondoRef ki, UINT * bitfield)
{
	assert(ki);
	int i;

	// build command to read mem_h from RAM to COM
	ki->swap[0] = 10; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_RAM_TO_COM; // RAM to COM
	ki->swap[3] = 0; // dest addr L (0 for COM)
	ki->swap[4] = 0; // dest addr M (0 for COM)
	ki->swap[5] = 0; // dest addr H (0 for COM)
	ki->swap[6] = (UCHAR) (RCB4_ADDR_PIO_SET); // mem_h low byte
	ki->swap[7] = (UCHAR) (0); // mem_h high byte
	ki->swap[8] = 2; // bytes to move
	ki->swap[9] = kondo_checksum(ki, 9); // checksum

	// send 10, expect 5 in response
	if ((i = kondo_trx(ki, 10, 5)) < 0)
		return i;

	// verify response
	if (i != 5 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was invalid");

	// save result
	if (bitfield)
		*bitfield = (((UINT) (ki->swap[3]) << 8) | ki->swap[2]) & 0x2F;

	return 0;
}

/*-----------------------------------------------------------------------------
 * Write to the PIO port.
 * bitfield: 9-bits where PIO1 is bit 0 (low order bit); PIO10 is bit 9.
 * NOTE: At power-on, the PIO direction defaults to 1 (Output) for all ports.
 * You will need to set the PIO direction to Output for the ports you would
 * like to write values to.
 * Returns: 0 if successful, < 0 if error.
 */
int kondo_write_pio(KondoRef ki, UINT bitfield)
{
	assert(ki);
	int i;

	// mask bitfield
	bitfield = bitfield & 0x2F;

	// build command to send val into the counter
	ki->swap[0] = 10; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_COM_TO_RAM; // COM to RAM
	ki->swap[3] = (UCHAR) (RCB4_ADDR_PIO_OUTPUT); // dest addr L
	ki->swap[4] = 0; // dest addr H
	ki->swap[5] = 0; // 0 for RAM destination
	ki->swap[6] = (UCHAR) (bitfield); // value to send
	ki->swap[7] = (UCHAR) (bitfield >> 8);
	ki->swap[8] = 2; // bytes to move
	ki->swap[9] = kondo_checksum(ki, 9); // checksum

	// send 10, expect 4 in response
	if ((i = kondo_trx(ki, 10, 4)) < 0)
		return i;

	// verify response
	if (i != 4 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was not valid");

	return 0;
}

/*-----------------------------------------------------------------------------
 * Set the counter value
 * num: the counter to set (0 to 10)
 * val: the value to set the counter to
 * Returns: 0 if successful, < 0 if error.
 */
int kondo_set_counter(KondoRef ki, UINT num, UCHAR val)
{
	assert(ki);
	int i;

	if (num < 0 || num > 10)
		kondo_error(ki, "Invalid counter number");

	UINT dest_addr = RCB4_ADDR_COUNTER_BASE + num;

	// build command to send val into the counter
	ki->swap[0] = 9; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_COM_TO_RAM; // COM to RAM
	ki->swap[3] = (UCHAR) (dest_addr); // dest addr L
	ki->swap[4] = (UCHAR) (dest_addr >> 8); // dest addr H
	ki->swap[5] = 0; // 0 for RAM destination
	ki->swap[6] = (UCHAR) (val); // value to send
	ki->swap[7] = 1; // bytes to move
	ki->swap[8] = kondo_checksum(ki, 8); // checksum

	// send 9, expect 4 in response
	if ((i = kondo_trx(ki, 9, 4)) < 0)
		return i;

	// verify response
	if (i != 4 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was not valid");

	return 0;
}

/*-----------------------------------------------------------------------------
 * Read a counter value
 * num: the counter to read
 * Side effect: The counter value is read into 'result'.
 * Returns: 0 if successful, < 0 if error.
 */
int kondo_get_counter(KondoRef ki, UCHAR * result, UINT num)
{
	assert(ki);
	int i;

	// check counter number range
	if (num < 0 || num > 10)
		kondo_error(ki, "Invalid counter number");

	UINT addr = RCB4_ADDR_COUNTER_BASE + num;

	// build command to read from RAM to COM
	ki->swap[0] = 10; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_RAM_TO_COM; // RAM to COM
	ki->swap[3] = 0; // dest addr L (0 for COM)
	ki->swap[4] = 0; // dest addr M (0 for COM)
	ki->swap[5] = 0; // dest addr H (0 for COM)
	ki->swap[6] = (UCHAR) (addr); // mem_h low byte
	ki->swap[7] = (UCHAR) (addr >> 8); // mem_h high byte
	ki->swap[8] = 1; // bytes to move
	ki->swap[9] = kondo_checksum(ki, 9); // checksum

	// send 10, expect 4 in response
	if ((i = kondo_trx(ki, 10, 4)) < 0)
		return i;

	// verify response
	if (i != 4 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was not valid.");

	// save result
	if (result)
		*result = ki->swap[2];

	return 0;
}

/*-----------------------------------------------------------------------------
 * Send an ICS pos frame to all servos selected in the bitfield.
 * servos[5]: a bit field of all the servos to send to.
 * frame: two-byte ICS frame to send
 * 	free position is 0x8000 (32768)
 *  hold position is 0x7fff (32767)
 *  center position is 0x1d4c (7500)
 * Returns: < 0 if error, 0 if OK
 */
int kondo_send_ics_pos(KondoRef ki, UCHAR servos[5], UINT frame)
{
	assert(ki);
	int ret;

	// build command to send ICS frame
	ki->swap[1] = RCB4_CMD_ICS; // ICS command
	ki->swap[2] = servos[4];
	ki->swap[3] = servos[3];
	ki->swap[4] = servos[2];
	ki->swap[5] = servos[1];
	ki->swap[6] = servos[0];
	ki->swap[7] = 0x1;

	// count servos used
	int c, i;
	for (c = 0, i = 0; i < 5; i++)
		for (; servos[i]; c++)
			servos[i] &= servos[i] - 1;

	// for each servo prepare frame
	for (i = 8; i < 8 + (c * 2); i += 2) {
		ki->swap[i] = (UCHAR) (frame);
		ki->swap[i + 1] = (UCHAR) (frame >> 8);
	}

	ki->swap[0] = i + 1; // num bytes + checksum
	ki->swap[i] = kondo_checksum(ki, i); // checksum

	// send i+1, expect 4 in response
	if ((ret = kondo_trx(ki, i + 1, 4)) < 0)
		return i;

	// verify response
	if (i != 4 || ki->swap[1] != RCB4_CMD_ICS)
		kondo_error(ki, "Response was not valid");

	return 0;
}

/*-----------------------------------------------------------------------------
 * Get the position of the selected servo
 * Returns: < 0 if error, or pos >= 0;
 */
int kondo_get_servo_pos(KondoRef ki, UINT servo_idx)
{
	return kondo_get_servo_data(ki, servo_idx, RCB4_SERVO_POS_OFFSET);
}

/*-----------------------------------------------------------------------------
 * Get the ID of the selected servo
 * Returns: < 0 if error, or pos >= 0;
 */
int kondo_get_servo_id(KondoRef ki, UINT servo_idx)
{
	return kondo_get_servo_data(ki, servo_idx, RCB4_SERVO_ID_OFFSET);
}

/*-----------------------------------------------------------------------------
 * Get the set pos of the selected servo
 * Returns: < 0 if error, or pos >= 0;
 */
int kondo_get_servo_setpos(KondoRef ki, UINT servo_idx)
{
	return kondo_get_servo_data(ki, servo_idx, RCB4_SERVO_SETPOS_OFFSET);
}

/*-----------------------------------------------------------------------------
 * Get the trim of the selected servo
 * Returns: < 0 if error, or pos >= 0;
 */
int kondo_get_servo_trim(KondoRef ki, UINT servo_idx)
{
	return kondo_get_servo_data(ki, servo_idx, RCB4_SERVO_TRIM_OFFSET);
}

/*-----------------------------------------------------------------------------
 * Get the given 2-byte field of data from a servo
 * Returns: < 0 if error, or pos >= 0;
 */
int kondo_get_servo_data(KondoRef ki, UINT servo_idx, UINT offset)
{
	assert(ki);
	int i;

	// check port number range
	if (servo_idx < 0 || servo_idx > RCB4_NUM_SERVOS)
		kondo_error(ki, "Invalid servo index");

	// check field
	if (offset < 0 || offset >= 58)
		kondo_error(ki, "Invalid servo field");

	UINT ram_addr = RCB4_ADDR_SERVO + (RCB4_SERVO_DATA_SIZE * servo_idx)
			+ offset;

	// command
	ki->swap[0] = 10; // number of bytes
	ki->swap[1] = RCB4_CMD_MOV; // move command
	ki->swap[2] = RCB4_RAM_TO_COM; // RAM to COM
	ki->swap[3] = 0; // addr L
	ki->swap[4] = 0; // addr M
	ki->swap[5] = 0; // addr H
	ki->swap[6] = (UCHAR) (ram_addr); // ram L
	ki->swap[7] = (UCHAR) (ram_addr >> 8); // ram M
	ki->swap[8] = 2; // bytes to move
	ki->swap[9] = kondo_checksum(ki, 9); // checksum

	// send 10, expect 5 in response
	if ((i = kondo_trx(ki, 10, 5)) < 0)
		return i;

	// verify response
	if (i != 5 || ki->swap[1] != RCB4_CMD_MOV)
		kondo_error(ki, "Response was not valid");

	// everything ok, return result
	UINT result = (ki->swap[3] << 8) | ki->swap[2];

	return result;
}


int kondo_move(KondoRef ki, UINT num)
{
    assert(ki);
    int i;
    UCHAR chk;

    // (2) call motion script -------------------------------------------------
    // You have to compute the motion address (base + num * size) and call it.
    ki->swap[0] = 7; // num bytes
    ki->swap[1] = RCB4_CMD_SIN_MOVE; // command
    ki->swap[2] = SEVOR01*num; // sevor number
    ki->swap[3] = 0xFF; // velocity
    ki->swap[4] = 0x00; // position H
    ki->swap[5] = 0x0F; // position L
    ki->swap[6] = kondo_checksum(ki, 6);

    printf("joint num %x\n",ki->swap[2]);

    // send 7 bytes, expect 4 in response
    if ((i = kondo_trx(ki, 7, 4)) < 0)
        return i;

    // verify response (ack)
    if (i != 4 || ki->swap[2] != RCB4_ACK_BYTE)
    kondo_error(ki, "Bad response trying to call the motion.");

    if ((i = kondo_get_options(ki)) < 0)
        return i;

    return 0;
}
