cmake_minimum_required(VERSION 2.8)

project(kondo)
set(CMAKE_BUILD_TYPE Release)

set(CMAKE_C_FLAGS "${CMAKE_C_FLAGS} -fPIC")
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -fPIC")
set(CMAKE_MODULE_PATH ${CMAKE_MODULE_PATH} "${CMAKE_SOURCE_DIR}/cmake")
message(STATUS "CMAKE_MODULE_PATH: ${CMAKE_MODULE_PATH}")

find_package(FTDI REQUIRED)
find_package(LIBUSB REQUIRED)

file(GLOB HEADERS "include/*.h")
file(GLOB SOURCES "src/*.cpp")

include_directories(include ${FTDI_INCLUDE_DIR}) #${LIBUSB_INCLUDE_DIRS})
add_library(kondo SHARED ${SOURCES})
target_link_libraries(kondo ${FTDI_LIBRARY}) #${LIBUSB_LIBRARIES})

#add_subdirectory(python)

add_executable(test_kondo_move utils/test_kondo_move.cpp ${SOURCES})
target_link_libraries(test_kondo_move ${FTDI_LIBRARY}) #${LIBUSB_LIBRARIES})


add_executable(test_kondo_set_angle utils/test_kondo_set_angle.cpp ${SOURCES})
target_link_libraries(test_kondo_set_angle ${FTDI_LIBRARY}) #${LIBUSB_LIBRARIES})



#add_executable(test_ics utils/test_ics.cpp ${SOURCES})
#target_link_libraries(test_ics m ${FTDI_LIBRARY}) #${LIBUSB_LIBRARIES})
#
#add_executable(test_digital utils/test_digital.cpp ${SOURCES})
#target_link_libraries(test_digital ${FTDI_LIBRARY}) #${LIBUSB_LIBRARIES})
#
#add_executable(test_analog utils/test_analog.cpp ${SOURCES})
#target_link_libraries(test_analog ${FTDI_LIBRARY}) #${LIBUSB_LIBRARIES})
