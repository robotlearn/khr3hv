# - Find FTDI Installation
# This module tries to find the libftdi installation on your system.
# Once done this will define
#
# FTDI_FOUND - system has ftdi
# FTDI_INCLUDE_DIR - the ftdi include directory
# FTDI_LIBRARY - link these to use ftdi

FIND_PATH(FTDI_INCLUDE_DIR
NAMES 	ftdi.h
PATHS 	/usr/local/include
	/usr/include
	/opt/local/include
PATH_SUFFIXES libftdi libftdi1
)

FIND_LIBRARY(FTDI_LIBRARY
NAMES	ftdi ftdi1
PATHS	/usr/lib
	/usr/local/lib
	/opt/local/lib
)

IF (FTDI_LIBRARY)
  IF (FTDI_INCLUDE_DIR)
    set(FTDI_FOUND TRUE)
    MESSAGE(STATUS "Found libFTDI: ${FTDI_INCLUDE_DIR}, ${FTDI_LIBRARY}")
  ELSE (FTDI_INCLUDE_DIR)
    set(FTDI_FOUND FALSE)
    MESSAGE(STATUS "libFTDI headers NOT FOUND. Make sure to install the development headers!")
  ENDIF (FTDI_INCLUDE_DIR)
ELSE (FTDI_LIBRARY)
  set(FTDI_FOUND FALSE)
  MESSAGE(STATUS "libFTDI NOT FOUND.")
ENDIF (FTDI_LIBRARY)

set(FTDI_INCLUDE_DIR ${FTDI_INCLUDE_DIR})
