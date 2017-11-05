

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
