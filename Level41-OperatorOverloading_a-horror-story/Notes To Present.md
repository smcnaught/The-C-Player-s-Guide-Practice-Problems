Level 41 - Operator Overloading (A Horror Story)

- Operator overloading is redefining how built in operators (+, -, *, indexers, etc.) work. 🤮
  
- You cannot overload all operators, but most work.
  
- You cannot invent new operators.
  
- Operators are just static methods with the *operator* keyword & an operator instead of a name.
  
- When defining an operator parameter order matters. You might have to define two operators so you can mix and match arguments when using your operator.
  - i.e., (p * 3) vs. (3 * p)
  
- Operator overloading can always be done with methods instead. The book says to choose the one that makes your code readable.
  - I think we know what this means: never do operator overloading. 😂
  
- Any type that defines an indexer can use index initializer syntax. Basically init values via the compiler that you cannot see written.
  - This seems like an absolute debugging nightmare.
  
- Since a long can store every value that an int can hold, we allow an *implicit* conversion (no cast required). However int cannot hold all values of a long, so we also have an *explicit* conversion (cast required). When doing operator overloading, if you're going to do a conversion that might lose data, you should define your operator as ***explicit***. 

- Custom conversions of reference types actually create new objects. This can be hard to see and harder to debug.
  - Author says "Custom conversions are not bad or evil". I think he was coerced, but not sure by whom. 😅