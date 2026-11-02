cmake_minimum_required(VERSION 3.10)

# Name your project
project(MajorityElement)

# Set the C++ standard
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# Tell CMake to build an executable named 'my_program' from 'main.cpp'
add_executable(main 
				generateTest.cpp
				main.cpp)