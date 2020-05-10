# Key C# Features

### OOP
1. Encapsulation
2. Polymorphism
3. Inheritance (unlike C++, only single Class Inheritance is supported); however, Interfaces support multiple-inheritance)
4. Abstraction

### Exception Handling
- Handle runtime errors

### Type Saftey
- Validation of variables at compile time

### Memory Management
- Built-in Garbage Collection

### Platform Independent
- Just-In-Time (JIT) compilation (see below)

### Compilation
1. You write C# code in an IDE, i.e. Visual Studio
2. Your C# code is translated into IL (aka MSIL), similar to Java ByteCode
3. The CLR (Common Language Runtime) converts IL code to native machine code (this makes C# platform independent, and is known as Just-In-Time (JIT) compilation)

### CLR
1. Facilitates JIT compilation
2. Memory management for running processes
2. Reserves space in memory - a managed heap
3. The heap maintains a pointer to where the next object defined in a process will be allocated in memory

