-------------------------------------------------------------------------------
 libkondo4
 A small C library to control the Kondo RCB-4 and ICS 3.0 protocols.
 
 Christopher Vo
 cvo1 at cs.gmu.edu
 Autonomous Robotics Laboratory
 George Mason University
-------------------------------------------------------------------------------

1. INSTALLATION

    You will need libusb and libftdi:
    libusb:  http://www.libusb.org/
    libftdi: http://www.intra2net.com/en/developer/libftdi/
    
    It has been tested on Linux 32-bit and 64-bit. 

    On Ubuntu 10.04, you can get libusb using this:
        sudo apt-get install libusb-dev libusb-0.1-4

    To build, there is an example Makefile included.
    Just type 'make'.
    
    The Makefile creates a shared DLL (libkondo.so) and static lib (libkondo.a)
        in the main directory, which you can use in your programs. 

2. USAGE

    Most of the function documentation is in the comments in libkondo.c
    There are also some usage examples in the utils directory,
    And a demo of using the wiimote to remote-control the rcb4 in "wii"
    And Java bindings (using SWIG) example in "java"
    And Python bindings (using SWIG) example in "python"
    And serial (termios API) examples in "serial"

3. LICENSE AND COPYRIGHT

    Copyright 2010 - Christopher Vo (cvo1@cs.gmu.edu)
    George Mason University - Autonomous Robotics Laboratory

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at
    
       http://www.apache.org/licenses/LICENSE-2.0
    
    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.