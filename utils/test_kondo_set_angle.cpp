
#include "kondo.h"



kondo ki;

int main(int argc, char *argv[])
{
    // check cmd-line arguments -----------------------------------------------
    if (argc < 3) {
        fprintf(stderr, "Usage: joint_index, angle_in_deg \n");
        exit(1);
    }

    // open -------------------------------------------------------------------
    int ret = ki.kondo_init();
    if (ret < 0) {
        exit(-1);
    }

    // move one joint ---------------------------------------------------------
    printf("Start to move.\n");
    int jointIndex = atoi(argv[1]);
    double angleInDegree = atoi(argv[2]);
    double fractionMaxSpeed = 1.0;
    ret = ki.kondo_set_angle(jointIndex, angleInDegree, fractionMaxSpeed);
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
