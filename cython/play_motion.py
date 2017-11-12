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

def main():

    # initialize
    print("Initializing...")
    kondo = Kondo()
    ret = kondo.init()
    if ret < 0:
        #sys.exit(ki.error)
        print("Error during init...")
        sys.exit()

    print("Play motion...")
    # play motion
    if sys.version_info[0] == 2: # Python 2
        idx = int(raw_input('Enter the id of the motion you want to play (between 1 and 120)s: '))
    else: # Python 3
        idx = int(input('Enter the id of the motion you want to play (between 1 and 120)s: '))

    max_wait = 50 * 1000000
    kondo.play_motion(idx, max_wait)

    if ret < 0:
        #sys.exit(ki.error)
        print("Error while playing the motion...")
        sys.exit()

    time.sleep(15)

    print("Closing...")
    # clean up
    ret = kondo.close()
    if ret < 0:
        #sys.exit(ki.error)
        print("Error while closing...")
        sys.exit()

if __name__ == "__main__":
    main()
