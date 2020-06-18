# Compilers and Interpreters

### Compilation
- Lexical analysis (lexing) - classify each token (each word)
- Syntax Analysis (parsing) - creates a parse tree using the tokens that were identified during the above lexing process
- Semantic Analysis - language rule checks, i.e. type mismatches, use of undeclared variables, parameter mismatches, etc.
- Optimization - breaks down syntax sugar
- Code Generation - compile code based on hardware platform

### Interpreters
- Parses and may execute code
- Or the code is compiled into IL (or bytecode) then executed in a VM
- *** Python actually runs code in a VM in the background