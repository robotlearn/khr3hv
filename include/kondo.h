#ifndef KONDO_H
#define KONDO_H

/*
 kondo class include the libkondo4 functions.
 libkondo4 is a small open source C library project by Christopher Vo for controlling the servos and servo controller in the Kondo KHR-3HV humanoid robot kit.
 https://bitbucket.org/vo/libkondo4/wiki/Home
*/


#include <iostream>
#include <vector>
#include <math.h>
#include <unistd.h>

// user defined
#define NUMBER_OF_JOINTS 17 // by default, the robot has 17 servos, but we can add few more
#define DOTS_PER_DEGREE 29
#define DEGREES_PER_DOT 0.0344827586
#define INI_SERVO_DOT 7500
#define SERVO_SPEED_RANGE 255
#define LOOP_CYCLE_DURATION 20000
#define CYCLE_DURATION_50HZ 20000
#define CYCLE_DURATION_200HZ 5000

// general --------------------------------------------------------------------
#define RCB4_SECOND 1000000
#define RCB4_15MS 15000
#define RCB4_50MS 50000

// communcation ---------------------------------------------------------------
#define RCB4_USB_VID 0x165c
#define RCB4_USB_PID 0x0008 //0x0007
//#define RCB4_USB_VID 0x0403 // FTDI Ltd. Devices
//#define RCB4_USB_PID 0x6001 // FT232RL (Kondo USB-UART)
//#define RCB4_USB_PID 0x6011 // FT4232H (4-port USB-UART)
//#define RCB4_USB_PID 0x6010 // FT2232H/D (2-port USB-UART)
#define RCB4_BAUD 1250000 //115200
#define RCB4_SWAP_SIZE 256
#define RCB4_RX_TIMEOUT 1000000

// rcb4 -----------------------------------------------------------------------

// byte codes
#define RCB4_ACK_BYTE  0x06 // acknowledge byte
#define RCB4_NCK_BYTE  0x15 // negative acknowledge byte
// sub-commands
#define RCB4_CMD_ACK   0xFE // ACK command
#define RCB4_CMD_MOV   0x00 // MOV command
#define RCB4_CMD_CALL  0x0C // CALL command
#define RCB4_CMD_VERS  0xFD // Version command
#define RCB4_CMD_ICS   0x10 // ICS frame command
#define RCB4_CMD_SIN_MOVE 0x0F // single move command (new)
// moter ICS number
#define SEVOR00 0x00
#define SEVOR01 0x01
#define SEVOR02 0x02
#define SEVOR03 0x03
#define SEVOR04 0x04
#define SEVOR05 0x05
#define SEVOR06 0x06
#define SEVOR07 0x07
#define SEVOR08 0x08
#define SEVOR09 0x09
#define SEVOR10 0x0A
#define SEVOR11 0x0B

// device types
#define RCB4_DEV_RAM   0x00 // RAM
#define RCB4_DEV_DEV   0x01 // Device
#define RCB4_DEV_COM   0x02 // COM port
#define RCB4_DEV_ROM   0x03 // ROM
#define RCB4_RAM_TO_COM ((RCB4_DEV_COM << 4) | RCB4_DEV_RAM)
#define RCB4_COM_TO_RAM ((RCB4_DEV_RAM << 4) | RCB4_DEV_COM)

// option bits
#define RCB4_OPT_BYTES     2        // number of option bytes
#define RCB4_OPT_SIO       (1 << 0) // ICS on/off
#define RCB4_OPT_EEPROM    (1 << 1) // EEPROM on/off
#define RCB4_OPT_RESP      (1 << 2) // Servo response on/off
#define RCB4_OPT_VEC       (1 << 3) // Vector jump flag
#define RCB4_OPT_FRAME_10MS (0x0 << 4) // Frame interval
#define RCB4_OPT_FRAME_20MS (0x1 << 4)
#define RCB4_OPT_FRAME_15MS (0x2 << 4)
#define RCB4_OPT_FRAME_25MS (0x3 << 4)
#define RCB4_OPT_COM_BAUD_125200  (0x0 << 6) // COM Baud Rates
#define RCB4_OPT_COM_BAUD_625000  (0x2 << 6)
#define RCB4_OPT_COM_BAUD_1250000 (0x1 << 6)
#define RCB4_OPT_ZERO      (1 << 8)  // zero flag
#define RCB4_OPT_CARRY     (1 << 9)  // carry flag
#define RCB4_OPT_ERROR     (1 << 10) // program error
#define RCB4_OPT_ICS_BAUD_125200  (0x0 << 13) // ICS Baud Rates
#define RCB4_OPT_ICS_BAUD_625000  (0x2 << 13)
#define RCB4_OPT_ICS_BAUD_1250000 (0x1 << 13)
#define RCB4_OPT_GREEN_LED (1 << 15) // Green LED
// hard-coded option bytes
#define RCB4_OPT_LOW  0x11   // hard-coded option bytes
#define RCB4_OPT_HIGH 0x0

// addresses stuff in ROM / RAM
#define RCB4_ADDR_OPT  0x0000 // Option bytes
#define RCB4_ADDR_PGC 0x0002 // program counter address (rw)
#define RCB4_ADDR_EEPROM_FLAG 0x0007 // ROM address update flag (ro)
#define RCB4_ADDR_AD_REF_BASE 0xC // analog reference value address (rw)
#define RCB4_ADDR_AD_READ_BASE 0x22 // analog reading address (ro)
#define RCB4_NUM_ANALOGS 11 // number of analog ports (AD0-AD10)
#define RCB4_ADDR_PIO_SET 0x38 // PIO direction setup (rw) (1=Out, 0=In)
#define RCB4_ADDR_PIO_OUTPUT 0x3A // PIO output (rw) (1=GND, 0=Vcc)
#define RCB4_ADDR_TIMER_0 0x3C // Timer 0 (rw)
#define RCB4_ADDR_TIMER_1 0x3E // Timer 1 (rw)
#define RCB4_ADDR_TIMER_2 0x40 // Timer 2 (rw)
#define RCB4_ADDR_TIMER_3 0x42 // Timer 3 (rw)
#define RCB4_ADDR_ICS_BASE 0x44 // ICS base address
#define RCB4_NUM_ICS 36 // number of ICS addresses
#define RCB4_ADDR_MAIN 0x03FD // main program loop
#define RCB4_ADDR_SERVO 0x90 // Servo data address (20 bytes ea)
#define RCB4_SERVO_DATA_SIZE 20 // Bytes per servo
#define RCB4_NUM_SERVOS 34 // Max servos
#define RCB4_ADDR_KRI  0x034C // KRI data start
#define RCB4_ADDR_BTN_L 0x50  // KRI button data start (0x350)
#define RCB4_ADDR_BTN_M 0x03  //
#define RCB4_ADDR_BTN_H 0x00  //
#define RCB4_ADDR_MOT_BASE  3000 // motion base address
#define RCB4_MOT_SIZE  2048   // motion slot num bytes
#define RCB4_MOT_MAX   241336 // highest motion
#define RCB4_SERVO_ID_OFFSET 1 // data offset for ID
#define RCB4_SERVO_SETPOS_OFFSET 6 // data offset for set pos
#define RCB4_SERVO_POS_OFFSET 4 // data offset for curr pos
#define RCB4_SERVO_TRIM_OFFSET 2 // data offset for TRIM
#define RCB4_ADDR_COUNTER_BASE 0x457 // counter base address
#define RCB4_NUM_COUNTERS 11 // number of counters (0-10)
// button codes
#define RCB4_BTN_NP 0         // nothing
#define RCB4_BTN_LU (1 << 0)  // left pad up
#define RCB4_BTN_LD (1 << 1)  // left pad down
#define RCB4_BTN_LR (1 << 2)  // left pad right
#define RCB4_BTN_LL (1 << 3)  // left pad left
#define RCB4_BTN_RU (1 << 4)  // right pad up (triangle)
#define RCB4_BTN_RD (1 << 5)  // right pad down (cross)
#define RCB4_BTN_RR (1 << 6)  // right pad right (circle)
#define RCB4_BTN_RL (1 << 8)  // right pad left (square)
#define RCB4_BTN_S1 (1 << 9)  // shift (L trigger U)
#define RCB4_BTN_S2 (1 << 10) // shift (L trigger D)
#define RCB4_BTN_S3 (1 << 11) // shift (R trigger D)
#define RCB4_BTN_S4 (1 << 12) // shift (R trigger U)

#ifndef __UCHAR__
#define __UCHAR__
typedef unsigned char UCHAR;
#endif

#ifndef __UINT__
#define __UINT__
typedef unsigned int UINT;
#endif

// instance data --------------------------------------------------------------
typedef struct
{
    struct ftdi_context ftdic; // ftdi context
    UCHAR swap[RCB4_SWAP_SIZE]; // swap space
    char error[128]; // error messages
    UCHAR opt[RCB4_OPT_BYTES]; // option bytes
    int debug; // whether to print debug info
} KondoInstance;

class kondo
{
private:
    KondoInstance ki;

public:
    // self defined
    int kondo_set_angle(UINT jointIndex, double angleInDegree, double fractionMaxSpeed);
    int kondo_set_angles(std::vector<UINT> jointIndices, std::vector<double> anglesInDegree, double fractionMaxSpeed);

    // initialization / deinitialization ------------------------------------------
    int kondo_init();
    int kondo_init_custom( int baud, int vid, int pid, int interface);
    int kondo_close();

    // basic communication --------------------------------------------------------
    int kondo_write( int n);
    int kondo_read( int n);
    int kondo_read_timeout( int n, long timeout);
    int kondo_purge();
    int kondo_trx( int out_bytes, int in_bytes);

    // rcb4 commands --------------------------------------------------------------
    int kondo_move( UINT num);
    int kondo_ack();
    int kondo_get_options();
    int kondo_play_motion( UINT num, long max_wait);
    int kondo_stop_motion();
    int kondo_krc3_buttons( UINT cc, UCHAR a1, UCHAR a2, UCHAR a3,
            UCHAR a4);
    int kondo_read_analog( int * result, UINT num);
    int kondo_set_pio_direction( UINT bitset);
    int kondo_get_pio_direction( UINT * bitset);
    int kondo_read_pio( UINT * result);
    int kondo_write_pio( UINT bitset);
    int kondo_set_counter( UINT num, UCHAR val);
    int kondo_get_counter( UCHAR * result, UINT num);
    int kondo_send_ics_pos( UCHAR servos[5], UINT frame);
    int kondo_get_servo_data( UINT servo_idx, UINT offset);
    int kondo_get_servo_trim( UINT servo_idx);
    int kondo_get_servo_setpos( UINT servo_idx);
    int kondo_get_servo_pos( UINT servo_idx);
    int kondo_get_servo_id( UINT servo_idx);

    // utility --------------------------------------------------------------------
    UCHAR kondo_checksum( int n);
    int kondo_verify_checksum( int n);
    int kondo_load_asciihex( const char * hex);

    // error handler
    void kondo_error(KondoInstance ki,const char *err);
    void kondo_ftdi_error(KondoInstance ki);




};

#endif // KONDO_H
