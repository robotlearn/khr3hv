#! /usr/bin/env python

#
# run_motion.py example for Python SWIG bindings
#
# Copyright 2010 - Christopher Vo (cvo1@cs.gmu.edu)
# George Mason University - Autonomous Robotics Laboratory
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#    http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

import sys
from pykondo import Kondo
import time
import sys

def main():

    # initialize
    print("Initializing...")
    kondo = Kondo()
    ret = kondo.init()
    if ret < 0:
        #sys.exit(ki.error)
        print("Error during init...")
        sys.exit()

    print("Current pos: ", kondo.get_servo_pos(0))
    print("Set pos: ", kondo.get_servo_setpos(0))

    if sys.version_info[0] == 2: # Python 2
        idx = int(raw_input('Enter the id of the servo that you want to free: '))
    else: # Python 3
        idx = int(input('Enter the id of the servo that you want to free: '))

    print('Freeing the selected servo')
    ret = kondo.free_servo(idx)
    if ret < 0:
        #sys.exit(ki.error)
        print("Error while freeing the servo...")
        sys.exit()
    print("Sleeping for 10 sec before holding the servo again...")
    time.sleep(10)

    print("Holding the servo...")
    ret = kondo.hold_servo(idx)
    if ret < 0:
        #sys.exit(ki.error)
        print("Error while freeing the servo...")
        sys.exit()

    print("Current pos: ", kondo.get_servo_pos(0))
    print("Set pos: ", kondo.get_servo_setpos(0))

    print("Closing...")
    # clean up
    ret = kondo.close()
    if ret < 0:
        #sys.exit(ki.error)
        print("Error while closing...")
        sys.exit()

if __name__ == "__main__":
    main()
