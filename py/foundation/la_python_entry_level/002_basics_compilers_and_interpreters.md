# Basics

### Compiled vs Interpreted
- Source Code --> Compiler --> Machine Code
- Source Code --> Interpreter --> Execute Code

### 
- Python actually uses a compiler behind the scenes
- And code is compiled to intermediate code (aka bytecode) which is what gets executed
- *** Seems Python also uses an Interpreter as well

### Compilation
1. Lexical (lexing) analysis (each word, aka token in a statement is classified)
1. Syntax analysis (parsing, where ordering and rules of the language is applied) 
1. Semantic analysis (verify nothing illegal exists, even if no syntax errors)
1. Optimization (the compiler will actually re-write some of your code, i.e. breaking down syntactic sugar)
1. Code generation