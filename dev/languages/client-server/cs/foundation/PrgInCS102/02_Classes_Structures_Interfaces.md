# Classes, Structures & Interfaces

### Access Modifiers - (accessibility/visibility)
- Public - from any assembly in the app
- Private - only class where declared
- Protected - same class, and derived classes
- Internal - same class, and derived classes in the same assembly
- Protected Internal - same class, same assembly, and derived classes in an external assembly
- Private Protected - same class, and derived class in same assembly - TODO: how is this different from Internal???
- KEY TAKEWAY - Protected aids with inheritance

### Data Types (managed by the GAC)
- Value Types (aka primitive types) - stored on the stack
- Reference Types - stored on the heap

### Value Types
- Real Numbers - decimal, double, float
- Whole Number - Long, Int, Short
- Other - Char, Bool, Byte

### Reference Types
- Stored on the heap
- A pointer is used to reference a location in memory
- Reference types include: class, interface and dynamic
- NOTE: dynamic types - avoid compile-time type checking, and are defined at runtime
- And of course, objects are a reference type; objects are an instance of a class, and use the 'new' keyword to instantiate then
- Stings are also reference types
- NOTE: stings are immutable, creating and modifying them in large apps can get expensive, as behind the scenes, a new string object gets created in memory - however, C# offers StringBuild to handle the manipulation of strings

### Struct Types
- *** Struct is a value type, as such, is stored on the stack (along with its members), and why your structs need to be lightweight
- Does not have a default ctor
- Cannot inherit from another struct
- However, structs are able to to inherit from Interfaces

### Interfaces
- You must the 'interface' keyword to declare an Interfaces
- InterfacesmMembers cannot have an access modifier
- Can contain properties
- Regarding methods, you only declare them, that is, no body/implementation
- Interfaces are automatically public