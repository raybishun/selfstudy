# Events & Delegates

### Events
- An event is a notification (or message) from an object that something has occurred/changed, i.e. a button being clicked 

### Delegates
- Delegates are commonly used to facilitate callbacks, and are similar to function pointers in C++ (however, are type-safe, secure and object-oriented)
- Delegates can be though of as simply a reference to one or methods that match the Delegate's signature
- Delegates provide a way to pass methods a parameters 

### Observer Pattern
- Delegates use the observer pattern, where subscribers are able to register with, and receive notifications from, a provider
- A practical implementation of the observer pattern are event handlers in Windows apps, where delegates serve as the plumbing between an event source and code that handles the event

### Initiating Delegate
1. (Regular) named methods (used prior to C# 2.0)
2. Anonymous functions (introduced in C# 2.0)
3. Lambda expressions (introduced in C# 3.0) 

### Anonymous Functions
- There are 2 types of anonymous functions: anonymous methods and lambda expressions

### Anonymous Methods
- Contain in-line expressions and/or statements

### Lambda Expressions
- Use the operator => operator
- Structure: input parameters => Expression
- Lambdas are very popular today, and something like LINQ (which supports any enumerable collection), makes heavy use of lambdas

### Built-in Delegates: Func
- Accepts 0 or up to 16 parameters
- The last last parameter is the out parameter, named TResult
- Returns a value as an out parameter

### Built-in Delegates: Action
- Accepts 0 or up to 16 parameters
- Does not return anything

### Events
- Allow an object to broadcast that something has occurred
- Are based on the delegate model
- Implement the Observer Pattern - where subscribers register for notifications, and publishers register for push notifications