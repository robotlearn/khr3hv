# setup.py
# 
# to launch it:
# $ python setup.py build_ext --inplace

from distutils.core import setup
from Cython.Build import cythonize
from distutils.extension import Extension

sourcefiles = ['pykondo.pyx',
               '../src/rcb4.cpp',
               '../src/kondo.cpp'] #'ckondo.pxd', '../src/kondo.cpp']
compile_opts = ['-std=c++11']
include_dirs = ['../include/', #rcb4.h, kondo.h
                '/usr/include/'] # ftdi.h
library_dirs = ['/usr/lib/x86_64-linux-gnu/'] # libftdi.so
libraries = ['ftdi']

ext_modules = [Extension('pykondo',
                         sourcefiles,
                         extra_compile_args=compile_opts,
                         include_dirs=include_dirs,
                         library_dirs=library_dirs,
                         libraries=libraries,
                         language='c++')]

setup(name='pykondo',
      author='Brian Delhaisse',
      author_email='briandelhaisse@gmail.com',
      description='Python wrapper for the Kondo KHR-3HV Robot Library',
      license='Apache 2.0',
      version='1.0.0',
      ext_modules=cythonize(ext_modules))
