# C Programming Language 

## Introduction

C is a versatile and general-purpose programming language that has been a cornerstone of computer programming for decades. It was developed in the early 1970s by Dennis Ritchie at Bell Labs and has since influenced many other programming languages. This guide will provide you with a comprehensive overview of the C programming language.

## History

C was created as an evolution of the B programming language and aimed to provide a more efficient and versatile tool for programming on early computer systems. It quickly became popular due to its portability and low-level system access capabilities.

## Basics

### Structure
A typical C program consists of functions, and it begins with the `main` function. Here's a basic structure:

```c
#include <stdio.h>

int main() {
    // Your code goes here.
    return 0;
}
```

### Data Types
C supports various data types, including ``int``, ``float``, ``double``, ``char``, and more. These define the kind of data a variable can hold.

### Variables
Variables are used to store data in memory. They must be declared with a data type before being used:

```c
int age = 30;
```

## Control Flow

### Conditional Statements
C offers conditional statements like ``if``, ``else if``, and ``else`` to make decisions in your code:

```c
if (condition) {
    // Code to execute if the condition is true.
} else {
    // Code to execute if the condition is false.
}
```

### Loops 
Loops allow you to repeat a block of code. C provides ``for``, ``while``, and ``do-while`` loops.

```c
for (int i = 0; i < 10; i++) {
    // Code to repeat 10 times.
}
```

### Functions
Functions in C allow you to break your code into smaller, reusable parts. The ``main`` function is the entry point of your program, but you can create your own functions as well.

```c
int add(int a, int b) {
    return a + b;
}
```

### Input and Output
C provides I/O functions like ``printf`` and ``scanf`` for displaying output and reading input:

```c
int age;
printf("Enter your age: ");
scanf("%d", &age);
```

### Memory Management
C allows you to manage memory explicitly. You can allocate and deallocate memory using functions like ``malloc`` and ``free``.

### Standard Libraries
C comes with a standard library that provides a range of functions for various purposes. Commonly used libraries include ``stdio.h`` for standard I/O, ``stdlib.h`` for memory management, and ``string.h`` for string manipulation.
