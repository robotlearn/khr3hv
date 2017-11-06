# setup.py
# 
# to launch it:
# $ python setup.py build_ext --inplace

from distutils.core import setup
from Cython.Build import cythonize
from distutils.extension import Extension
from sys import platform

sourcefiles = ['pykondo.pyx',
               # '../src/rcb4.cpp',
               '../src/kondo.cpp'] #'ckondo.pxd', '../src/kondo.cpp']
compile_opts = ['-std=c++11']
include_dirs = ['../include/', #rcb4.h, kondo.h
                '/usr/include/', # ftdi.h
                '/usr/local/include/'] # ftdi.h
if platform=='linux' or platform=='linux2': # Linux
    library_dirs = ['/usr/lib/x86_64-linux-gnu/'] # libftdi.so
elif platform=='darwin': # MacOSX
    library_dirs = ['/usr/local/lib/']
else:
    raise ValueError("This setup only works on a Linux system or MacOSX.")
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
