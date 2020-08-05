# C# 102, The Basics

### Introduction
- C# is a fully OOP, type-safe, multi-purpose language that is platform independent

### C# vs C
- OOP: Abstraction, Polymorphism, Inheritance, Encapsulation - not in C
- Exception Handling - not in C
- Type Safety: Compiler validates value of variables at compile time - limited in C

### C# vs C++
- OOP, available in both languages
- Memory Management, C# has built-in Garbage Collector - C++ does not
- Inheritance, C# does not support multiple class inheritance, however, inheritance from multiple Interfaces is support - C++ supports multi-level inheritance
- Pointers, C# supports pointers by declaring code as UnSafe - natively available in C++

### The .NET Framework Architecture
- C# code is compiled into IL (aka MSIL), similar to Java's ByteCode
- The CLR (which resides in memory) converts IL code into native machine code (specific to the underlying platform), this process is know as Just-In-Time (JIT) compilation, and is similar to Java's Virtual Machine
- The C# code you write, consumes a treasure trove of Class Libraries that make up the .NET framework, i.e. ADO.NET, ASP.NET, Core, WinForms, WPF, WCF, LINQ, the Task Parallel Library, and many, many more...
- The CLR is also responsible for auto memory management and security for your C# applications