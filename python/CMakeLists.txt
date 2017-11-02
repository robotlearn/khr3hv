find_package(SWIG REQUIRED)
include(${SWIG_USE_FILE})

find_package(PythonLibs 2.7)
include_directories(${PYTHON_INCLUDE_PATH})

include_directories(${CMAKE_CURRENT_SOURCE_DIR})
link_directories(${CMAKE_BINARY_DIR})

set(CMAKE_SWIG_FLAGS "")
#file(GLOB SOURCES "${CMAKE_SOURCE_DIR}/src/*.c")

#set_source_files_properties(pykondo.i PROPERTIES C ON)
#set_source_files_properties(pykondo.i PROPERTIES CPLUSPLUS ON)
##set_source_files_properties(pykondo.i PROPERTIES SWIG_FLAGS "-includeall")
swig_add_module(pykondo python pykondo.i ${SOURCES})
swig_link_libraries(pykondo kondo ${PYTHON_LIBRARIES})

file(COPY ${CMAKE_CURRENT_SOURCE_DIR}/run_motion.py
     DESTINATION ${CMAKE_CURRENT_BINARY_DIR})
