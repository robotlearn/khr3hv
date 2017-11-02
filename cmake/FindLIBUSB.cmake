# - Find LIBUSB Installation
# This module tries to find the libftdi installation on your system.
# Once done this will define
#
# LIBUSB_FOUND - system has ftdi
# LIBUSB_INCLUDE_DIR - the ftdi include directory
# LIBUSB_LIBRARY - link these to use ftdi

FIND_PATH(LIBUSB_INCLUDE_DIR
NAMES 	libusb.h
PATHS 	/usr/local/include
	/usr/include
	/opt/local/include
PATH_SUFFIXES libusb libusb-1.0
)

FIND_LIBRARY(LIBUSB_LIBRARY
NAMES	libusb libusb-1.0
PATHS	/usr/lib
	/usr/local/lib
	/opt/local/lib
	/usr/lib/x86_64-linux-gnu
)

IF (LIBUSB_LIBRARY)
  IF (LIBUSB_INCLUDE_DIR)
    set(LIBUSB_FOUND TRUE)
    MESSAGE(STATUS "Found libUSB: ${LIBUSB_INCLUDE_DIR}, ${LIBUSB_LIBRARY}")
  ELSE (LIBUSB_INCLUDE_DIR)
    set(LIBUSB_FOUND FALSE)
    MESSAGE(STATUS "libUSB headers NOT FOUND. Make sure to install the development headers!")
  ENDIF (LIBUSB_INCLUDE_DIR)
ELSE (LIBUSB_LIBRARY)
  set(LIBUSB_FOUND FALSE)
  MESSAGE(STATUS "libUSB NOT FOUND.")
ENDIF (LIBUSB_LIBRARY)

set(LIBUSB_INCLUDE_DIR ${LIBUSB_INCLUDE_DIR})
