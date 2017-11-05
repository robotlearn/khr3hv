# Robot class

from pykondo import Kondo
import time


class KHR_Robot(Kondo):

    def __init__(self):
        # Init Kondo
        super(KHR_Robot, self).__init__()

        # The robots has initially 17 servos/DoFs.
        # However, 5 dummy servos can be replaced by real servos.
        # axes are defined with x pointing in front of the robot,
        # y pointing on the left, and z pointing upward.
        self.joints = {'Neck': {'id': 0, 'limits': (-135,135), 'h_limits': (-80,80), 'axis': -1},
                        #0 Pelvis
                        'PelvisYaw': {'id': 1, 'limits': (0,0), 'h_limits': (0,0), 'axis': 0}, #NA
                        # Left arm
                        'LShoulderPitch': {'id': 2, 'limits': (-90,105), 'h_limits': (-70,105), 'axis': -1},
                        'LShoulderRoll': {'id': 4, 'limits': (-30,180), 'h_limits': (0,150), 'axis': 1},
                        'LUpperArmYaw': {'id': 6, 'limits': (0,0), 'h_limits': (0,0), 'axis': 0}, #NA
                        'LElbow': {'id': 8, 'limits': (-130,30), 'h_limits': (-130,0), 'axis': 1},
                        # Right arm
                        'RShoulderPitch': {'id': 3, 'limits': (-105,90), 'h_limits': (-105,70), 'axis': 1},
                        'RShoulderRoll': {'id': 5, 'limits': (-180,30), 'h_limits':(-150,0), 'axis': 1},
                        'RUpperArmYaw': {'id': 7, 'limits': (0,0), 'h_limits': (0,0), 'axis': 0}, #NA
                        'RElbow': {'id': 9, 'limits': (-30,130), 'h_limits': (0,130), 'axis': -1},
                        # Left Leg
                        'LHipYaw': {'id': 10, 'limits': (0,0), 'h_limits': (0,0), 'axis': 0}, #NA
                        'LHipRoll': {'id': 12, 'limits': (0,30), 'h_limits': (0,30), 'axis': 1},
                        'LHipPitch': {'id': 14, 'limits': (-90,90), 'h_limits': (-50,50), 'axis': -1},
                        'LKnee': {'id': 16, 'limits': (-60,135), 'h_limits': (0,110), 'axis': 1},
                        'LAnkPitch': {'id': 18, 'limits': (-100,120), 'h_limits': (-15,90), 'axis': 1},
                        'LAnkYaw': {'id': 20, 'limits': (-25,90), 'h_limits': (-10,45), 'axis': -1},
                        # Right Leg
                        'RHipYaw': {'id': 11, 'limits': (0,0), 'h_limits': (0,0), 'axis': 0}, #NA
                        'RHipRoll': {'id': 13, 'limits': (-30,0), 'h_limits': (-30,0), 'axis': 1},
                        'RHipPitch': {'id': 15, 'limits': (-90,90), 'h_limits': (-50,50), 'axis': 1},
                        'RKnee': {'id': 17, 'limits': (-135,60), 'h_limits': (-110,0), 'axis': -1},
                        'RAnkPitch': {'id': 19, 'limits': (-120,100), 'h_limits': (-90,15), 'axis': -1},
                        'RAnkYaw': {'id': 21, 'limits': (-90,25), 'h_limits': (-45,10), 'axis': -1}
                        }

        self.upper_joints = ['Neck', 'LShoulderPitch', 'LShoulderRoll', 'LElbow',
                             'RShoulderPitch', 'RShoulderRoll', 'RElbow']
        self.lower_joints = ['LHipYaw', 'LHipRoll', 'LHipPitch', 'LKnee', 'LAnkPitch', 'LAnkYaw',
                             'RHipYaw', 'RHipRoll', 'RHipPitch', 'RKnee', 'RAnkPitch', 'RAnkYaw']

        # initialize by opening and configuring the USB adapter
        self.init()

    def check_joints(self, joints):
        for jnt_name in joints:
            jnt = self.joints[jnt_name]
            # set the min limit for the jnt
            self.set_angle(jnt['id'], jnt['h_limits'][0], 0.8)
            time.sleep(2)
            self.set_angle(jnt['id'], jnt['h_limits'][1], 0.8)
            time.sleep(3)
            self.set_angle(jnt['id'], 0, 0.8)
            time.sleep(2)

    def check_upper_body_joints(self):
        """
        Check each joint in the upper body.
        For each joint, it goes to the associated min/max (soft) limit.
        """
        self.check_joints(self.upper_joints)
        

    def check_lower_body_joints(self):
        """
        Check each joint in the lower body.
        For each joint, it goes to the associated min/max (soft) limit.
        """
        self.check_joints(self.lower_joints)


print("Start")
robot = KHR_Robot()
print("sleeping...")
time.sleep(5)
print("checking upper body joints")
robot.check_upper_body_joints()
#print("checking lower body joints")
#robot.check_lower_body_joints()