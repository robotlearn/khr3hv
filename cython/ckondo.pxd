# Let Cython knows where are the C++ classes, and their definitions
# This file needs to be imported in the python wrapper file (.pyx)

from libcpp.vector import vector

# Typedef
ctypedef unsigned int UINT
ctypedef unsigned char UCHAR

# Let Cython knows that the class kondo is in kondo.h
cdef extern from "kondo.h":
    
    # class
    cdef cppclass Kondo:
        # Attributes
        cdef KondoInstance ki

        # Methods
        ## Set
        int kondo_set_angle(UINT jointIndex, double angleInDegree, double fractionMaxSpeed)
        int kondo_set_angles(vector[UINT] jointIndices, vector[double] anglesInDegree, double fractionMaxSpeed)

        ## init
        int kondo_init()
        int kondo_init_custom(int, int, int, int)
        int kondo_close()

        ## basic communication
        int kondo_write(int)
        int kondo_read(int)
        int kondo_read_timeout(int, long)
        int kondo_purge()
        int kondo_trx(int out_bytes, int in_bytes)

        ## rcb4 commands
        int kondo_move(UINT)
        int kondo_ack()
        int kondo_get_options()
        int kondo_play_motion(UINT, long)
        int kondo_stop_motion()
        int kondo_krc3_buttons(UINT, UCHAR, UCHAR, UCHAR, UCHAR)
        int kondo_read_analog(int*, UINT)
        int kondo_set_pio_direction(UINT)
        int kondo_get_pio_direction(UINT*)
        int kondo_read_pio(UINT *)
        int kondo_write_pio(UINT)
        int kondo_set_counter(UINT, UCHAR)
        int kondo_get_counter(UCHAR *, UINT)
        int kondo_send_ics_pos(UCHAR[5], UINT)
        int kondo_get_servo_data(UINT, UINT)
        int kondo_get_servo_trim(UINT)
        int kondo_get_servo_setpos(UINT)
        int kondo_get_servo_pos(UINT)
        int kondo_get_servo_id(UINT)

        ## utility
        UCHAR kondo_checksum(int)
        int kondo_verify_checksum(int)
        int kondo_load_asciihex(const char *)