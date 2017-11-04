# setup.py
# 
# to launch it:
# $ python setup.py build_ext --inplace

from distutils.core import setup
from Cython.Build import cythonize
from distutils.extension import Extension

sourcefiles = ['pykondo.pyx', 'kondo.cpp']
compile_opts = ['-std=c++11']

ext = [Extension('*',
				 sourcefiles,
				 extra_compile_args=compile_opts,
				 language='c++')]

setup(ext_modules=cythonize(ext))