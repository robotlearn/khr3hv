
#include "kondo.h"



kondo ki;

int main(int argc, char *argv[])
{
//    // check cmd-line arguments -----------------------------------------------
//    if (argc < 1) {
//        fprintf(stderr, "Usage: joint_index, angle_in_deg \n");
//        exit(1);
//    }

    // open -------------------------------------------------------------------
    int ret = ki.kondo_init();
    if (ret < 0) {
        exit(-1);
    }

    // move one joint ---------------------------------------------------------
    printf("Start to move.\n");
    std::vector<UINT> jointIndices = {0,2,3,4,5,8,9,12,13,14,15,16,17,18,19,20,21};
    std::vector<int> jointAxisDirFix = {-1,-1,1,1,1,1,-1,1,1,-1,1,1,-1,1,-1,-1,-1};
    std::vector<double> anglesInDegree = {5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0};
    anglesInDegree = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
    anglesInDegree = {5,5,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

    for(int i=0;i<anglesInDegree.size();i++){anglesInDegree.at(i) = anglesInDegree.at(i)*jointAxisDirFix.at(i);}
    double fractionMaxSpeed = 0.8;
    ret = ki.kondo_set_angles(jointIndices, anglesInDegree, fractionMaxSpeed);
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
