#
# Makefile example for Python SWIG bindings for libkondo4
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

CC:=gcc
LD:=${CC}
SWIG:=swig
CFLAGS:=-fPIC -pipe -O2 -fno-strict-aliasing
INCLUDES:=-I../ -I/usr/include/python2.7 -I/usr/include
	
# libkondo
KONDO_A:=../libkondo.a
KONDO_LDFLAGS:=-lusb -lftdi
	
# swig 
SWIG_OUTPUT:=\
	pykondo.py \
	pykondo_wrap.c

#------------------------------------------------------------------------------

all: _pykondo.so

clean:
	rm -rf Dependencies *.d *~
	rm -rf *.o *.pyc
	rm -rf $(SWIG_OUTPUT)
	rm -rf _pykondo.so

# making the swig C wrapper
pykondo_wrap.c : pykondo.i
	$(SWIG) $(INCLUDES) -python pykondo.i

# making libkondo_python.so from the swig wrapper
_pykondo.so: pykondo_wrap.o $(KONDO_A)
	$(LD) $(LDFLAGS) $(KONDO_LDFLAGS) -shared $^ -o $@
	
# how to build c
%.o : %.c
	$(CC) $(CFLAGS) $(INCLUDES) -MMD -c $< -o $@
	@cat $*.d >> Dependencies
	@rm -f $*.d

-include Dependencies

