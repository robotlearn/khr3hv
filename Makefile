#
# Makefile example for libkondo4
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

# flags
CC:=gcc
LD:=${CC}
AR:=ar -ruv
CFLAGS:=-fPIC -pipe -g
INCLUDES:=-I/usr/include/

# libkondo
KONDO_SRCS:=rcb4.c ics.c
KONDO_OBJS:=$(KONDO_SRCS:.c=.o)
KONDO_LDFLAGS:=-Wl,-rpath,. -Wl,-rpath,../ -fPIC -lusb -lftdi
KONDO_LIB:=libkondo.so
KONDO_STATICLIB:=libkondo.a

#------------------------------------------------------------------------------

all: $(KONDO_LIB) $(KONDO_STATICLIB)

clean:
	rm -rf $(KONDO_OBJS) 
	rm -rf $(KONDO_LIB) $(KONDO_STATICLIB)
	rm -rf Dependencies *.d *~

# libkondo (shared library)
$(KONDO_LIB) : $(KONDO_OBJS)
	$(LD) $(LDFLAGS) -shared $^ -o $@ $(KONDO_LDFLAGS)

# libkondo (static library archive)
$(KONDO_STATICLIB) : $(KONDO_OBJS)
	$(AR) $@ $^

# making object files from .c files in general
%.o : %.c
	$(CC) $(CFLAGS) $(INCLUDES) -MMD -c $< -o $@
	@cat $*.d >> Dependencies
	@rm -f $*.d

-include Dependencies

