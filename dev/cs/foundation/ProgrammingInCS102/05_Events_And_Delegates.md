# Events & Delegates

### Events
- An event is a notification (or message) from an object that something has occurred/changed, i.e. a button being clicked 

### Delegates
- Delegates are commonly used to facilitate callbacks, and are similar to function pointers in C++ (however, are type-safe, secure and object-oriented)
- Delegates can be though of as simply a reference to one or methods that match the Delegate's signature
- Delegates provide a way to pass methods a parameters 
- Anonymous methods (introduced in C# 2.0) can be used to initiate delegates
- Lambda expressions (introduced in C# 3.0) are now a more common way to initiate delegates 

### Observer Pattern
- Delegates use the observer pattern, where subscribers are able to register with, and receive notifications from, a provider
- A practical implementation of the observer pattern are event handlers in Windows apps, where delegates serve as the plumbing between an event source and code that handles the event
