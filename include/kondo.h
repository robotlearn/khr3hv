#ifndef KONDO_H
#define KONDO_H

#include "rcb4.h"
#include <iostream>
#include <vector>
#include <math.h>


/*
 kondo class include the libkondo4 functions.
 libkondo4 is a small open source C library project by Christopher Vo for controlling the servos and servo controller in the Kondo KHR-3HV humanoid robot kit.
 https://bitbucket.org/vo/libkondo4/wiki/Home
*/

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
