What is C#? 
`A general purpose programming language. You can make almost anything out of it.`

What does C# run on?
`.NET`

What is .NET?
`The framework that C# code builds on and runs within`
`A runime that supports your program, a library of code to build on, a set of tools to use to build programs (SDK)`

What is the SDK?
`.NET's software Development Kit. Collection of tools to build .NET programs.`

What is the BCL?
`.NET contains the *Base Class Library* which is C#'s standard library of tools (built in types, exception types, etc.)`

What is .NET core? 
`.NET Core (.NET 5) is the latest version of Microsoft’s .NET Framework.`

What can you use .NET core to create?
`You can use it to create all kinds of apps; such as: mobile, desktop, online, cloud, IoT, machine learning, games, microservices, etc.`

What is the difference between .NET core and .NET framework?
- `.NET core is open source where .NET framework only has some open source components`
- `.NET core is cross platform (Windows, Linux, MacOS) where .NET framework is only compatible with Windows`
- `.NET core supports microservices where .NET framework doesn't allow you to create microservices`
- `.NET core is more performant and scalable than .NET framework`
- `.NET core supports mobile app development where .NET framework is not`
- `.NET core has the CLI and you can switch to IDE if you want. .NET framework only has IDE (integrated development environment)`
- `.NET core is a collection of NuGet packages where .NET framework libraries are all shipped as a whole`

What is the latest version of .NET Core?
`3.0.3 - released February 2020`

What is the latest version of .NET Framework?
`4.8.1 - released August 2022`

What is the latest version of C#?
`11.0 - released November 2022`

What is the name of C#'s virtual machine? .NET's runtime
`Common Language Runtime (CLR)`

What is the name of the virtual instruction set C# compiles to?
`Common Intermediate Language (CIL or IL)`

How does a C# program run?
`In the applications main method inside the Program class`
`You can also use 'top-level statements' - just write some code and the compiler will add it to a main method under the covers.`

Name some configuration files in a C# project.
`.csproj and .sln files`

How do you build and run a .NET application?
`dotnet build`
`dotnet run`

What is a method?
`A method is a function that lives in a class`

How do you write a comment in C#?
`// or /**/`

What is a variable?
`A variable is a way to store data in memory. int myNum = 2`

What characters are valid in C# variable names?
`Variables must start with a letter or the _ character. After the first character you can use numbers`

Name the eight numeric types?
`int, short, long, byte, sbyte, uint, ushort, ulong`

Name the three types for storing real numbers (the floating-point data types)?
`float, double, decimal`

How many total numeric types are there?
`11`

What is the difference between float, double and decimal?
- `float uses 4 bytes, double uses 8 bytes, decimal uses 16 bytes`
- `float and double are faster`
- `decimal is more precise`
- `float uses the fewest bytes and it's precision level is good enough most the time`
- `append 'f' to make float, 'm' to make decimal`

If you are doing something that requires mathematical precision which type is the best?
`decimal`

What is the difference between signed and unsigned numeric types?
`**Signed** types store positive and negative numbers. **Unsigned** types store only positive numbers, but store twice as many`
`Examples of signed types: short, int, and long, sbyte`
`Examples of unsigned types: ushort, uint, and ulong, byte`

How do you convert between number types?
`Use the Convert class or cast`
`Convert.ToByte(toConvert)    - converts to byte`
`Convert.ToInt16(toConvert)   - converts to short`
`Convert.ToInt32(toConvert)   - converts to int`
`Convert.ToInt64(toConvert)   - converts to long`
`Convert.ToChar(toConvert)    - converts to char`
`Convert.ToSingle(toConvert)  - converts to float`
`Convert.ToDecimal(toConvert) - converts to decimal`
`Convert.ToSByte(toConvert)   - converts to sbyte`
`Convert.ToUInt16(toConvert)  - converts to ushort`
`Convert.ToUInt32(toConvert)  - converts to uint`
`Convert.ToUInt64(toConvert)  - converts to ulong`
`Convert.ToString(toConvert)  - converts to string`
`Convert.ToDouble(toConvert)  - converts to double`
`Convert.ToBoolean(toConvert) - converts to bool`

What are some risks with numeric conversions?
`Converting from long to byte could lose data since long could be bigger than what byte can represent`

What is the difference between explicit or implicit conversions?
`When the conversion is safe, no data could be lost (i.e. convert from long to int), an implicit conversion happens automatically.`
`When it's not safe, an explicit conversion (casting) is required.`

What is overflow in numeric types?
`When some operation causes a value to go beyond what it's type can represent`

What happens when a numeric type gets overflowed?
`the value wraps back around to the start of the range (so int would be 0)`

What does the char type do?
`stores single characters`

What does the string type store?
`text longer than a single character`

What does the bool type store?
`truth values - either true or false (or null)`

How much space does a bool use?
`A bool could theoretically just use a single bit, but it uses a whole byte :(`

What is an anonymous type?
`You can force the compiler to infer your variable type by using 'var' and object initializer syntax, Example: var anon = new { Name = "Steve", Age = 34 }`
`You can only use anonymous types within a method - you can't use them as a parameter, return type or field`

What is System.Convert used for?
`converting from one type to another`

What is a field or instance variable?
`variables that are created inside the objects memory on the heap. They live for as long as the object lives. (i.e. class variable)`

What is an operator?
`Addition(+), Subtraction(-), Multiplication(*), Division(/), and remainer/modulo(%)`

What is a compound assignment operator?
`+=, -=, *=, /=, %=`

What is an operation?
`A calculation that takes two numbers and combines them somehow.`

How do you get the max number in C#?
`Use MaxValue on any numeric type.          Example: int.MaxValue`
`Double & Float also have PositiveInfinity. Example: double.PositiveInfinity`

How do you get the min number in C#?
`Use MinValue on any numeric type.          Example: long.MinValue`
`Double & Float also have NegativeInfinity. Example: float.NegativeInfinity`

What is NaN?
`Means 'Not a Number' and is the result of an impossible value like division by zero.`

How do you add a variable inside a string?
`With string interpolation - Add a $ before the string and curly braces around the variable. Example: $"My string contains a {variable}" `
`With string concatenation - Example: "My favorite color is " + favColor + "." ` 

How do you read from the console?
`string userInputValue = Console.Readline()`

How do you write to the console?
`Console.WriteLine("Hey Console")`

What is the AND operator?
`&&`

What is the OR operator?
`||`

What is the NOT operator?
`!`

Name the types of loops?
`while, do while, for, and foreach(for lists & arrays - anything that extends IEnumerable)`
  `while (condition) {}`
  `do {} while (condition)`
  `for (int i = 0; i < 5; i++) {}`
  `foreach (string car in cars) {}`

What is the difference between break and continue?
`break exits the loop. continue jumps to next iteration`

What is an array?
`Used to hold multiple values of the same type. Has a fixed size (can't add or remove elements)`

How do you create an array?
`int[] myArr = new int[3] *OR* int[] myArr = new int[] {1, 2, 3} *OR* int[] myArr = new [] {1, 2, 3}`
`Example: string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};`

How do you check the number of items in an array?
`Using the Length property`

What is a list?
`Used to hold multiple values of the same type. Can add or remove elements after creation`

How do you check the number of items in a list?
`Using the Count property`

What are some built in list methods?
`Add()             - adds single element                                                     - Example: myList.Add(5)`
`AddRange()        - adds multiple elements                                                  - Example: myList.AddRange({"elem1", "elem2", "elem3"})`
`Clear()           - removes all elements                                                    - Example: myList.Clear()`
`Contains()        - checks if element exists in list                                        - Example: myList.Contains(4)`
`Find()            - searches for an element and returns first occurence                     - Example: myList.Find(x => x == "match")`
`FindAll()         - searches for an element and returns all occurences                      - Example: myList.FindAll(x => x == "match")`
`FindIndex()       - searches for an element and returns index of element or -1 if not found - Example: myList.FindIndex(x => x == "match")`
`ForEach()         - loops over each element in list                                         - Example: foreach (string car in cars) {}`
`Remove()          - remove first element that matches condition                             - Example: myList.Remove(x => x == "toRemove")`
`RemoveAt()        - remove item at index                                                    - Example: myList.RemoveAt(2)`
`RemoveAll()       - remove all elements matching condition                                  - Example: myList.RemoveAll(x => x == "toRemove")`
`Reverse()         - reverse the order of the elements in the list or specified range        - Example: myList.Reverse() OR myList.Reverse(1, 4)`
`Sort()            - sorts the elements using default or provided comparison                 - Example: myList.Sort() OR myList.Sort((a, b) => b - a)`
`ToString()        - returns a string that represents the current object                     - Example: myList.ToString() - would look like: System.Collections.Generic.List`
`Insert(pos, elem) - insert item at position                                                 - Example: myList.Insert(2, "carrot")`

How do you create a list?
`List<string> Food = new List<string>();`
`With initialization: List<string> myList = new List<string> { "One", "Two", "Three" };`

What is the difference between an array and a list?
`Arrays are fixed in size where lists can add or delete items.`

Why is it usually better to use a list instead of an array?
`Lists are more easily sorted, searched through and manipulated.`
`There are many built in functionalities to work with lists`

When should you use an array over a list?
`if your data is not going to grow.`
`if you’re dealing with large data that will need to be indexed into often.`

What is a jagged array?
`An multidimensional array that contains arrays of different sizes`

How do you create a new object / new instance of class?
`Person p = new Person() { Name = "Han Solo", Age = 39 };`

What is method overloading?
`Naming two methods identically, but they each have different parameters`

What is recursion?
`When a method calls itself`

What are access modifiers? (accessability modifiers)
`Public (usable anywhere)`
`Private            (only used within the class)`
`Internal           (only used inside the project - same assembly)`
`Protected          (only used within class or in a class derived from that class)`
`Protected Internal (only used in project or from derived class in another project)`
`Private Protected  (only used by types derived from the class within the project)`
`Default is private`

What is Linq?
`Language-Integrated Query allows you to perform queries on collections in your program`
`Filtering, combining, transforming, grouping, ordering, etc.`

What is a query expression (linq methods)?
`Allows you to extract specific pieces from your data and format it how you want`
`Made of multiple clauses: from, select, where, orderby, join, let, into, group`
`You can use query syntax or you can use the method calls (i.e. 'where' or 'Where()')`

What is the stack?
`allocates space for each method we call and then frees up memory when we're done using it`
`stack trace contains the path of the methods we called`

What is the heap?
`A set of objects connected by references`
`When we need memory in arbitrary sizes, we ditch the stack and use the heap.`
`Reference types are stored on the heap and include a reference to where on the heap they're stored`

What is a garbage collector?
`The garbage collector cleans up unused things on the heap. It lets heap memory be reused.`
`Not used on the stack. The stack manages itself.`

What is a value type?
`Value types directly contain their data. They have a known, fixed size.`
`The values types are: All numeric types (int, double, long, etc.), bool, struct, char`

What is a reference type? 
`A reference type variable stores a reference to where it's data is stored in memory(on the heap)`
`strings, classes, objects, lists and arrays`

How do you compare references types for value equality?
`You can use the ReferenceEquals method first for efficiency (and to handle null checks).`
`You could also check their types first for efficiency.`
`You can serialize both objects and compare the resulting strings. (compares values) Example: obj1.ToString() == obj2.ToString();`
`You can use the .Equals() method. (compares values)                                 Example: obj1.Equals(obj2);`

Describe the four principles of object oriented programming.
`1. Encapsulation: hiding data by restricting access to public methods (marking them private).`
`2. Abstraction: a class should not know the inner details of another in order to use it (should just know the interfaces).`
`3. Inheritance: let's you derive new classes based on existing ones. "is a" or "has a" relationships between objects. derived class(child) & base class(parent)`
`4. Polymorphism: lets a derived class override members declared in it's base class.`
  - `Members with 'virtual' can be overridden.`
  - `Use 'override' keyword to override in derived class.`
  - `Two versions of polymorphism: **compile-time** (static, adhoc, early binding) & **runtime** (dynamic, inclusion, subtyping, late binding)`
    - `Compile-Time Examples: Method overloading, constructor overloading and operator overloading`
    - `Runtime Examples: Method overriding, which involves inheritance and virtual functions`

What is object oriented programming?
`Separate large programs into objects each responsible for a piece of the program`

What is an enum?
`A type that has built in choices. Assigns numbers to the values you provide. First is default`
`Example with default numbers (winter 0, spring 1, etc.): enum Season { Winter, Spring, Summer, Fall }` 
`Example with custom number values                      : enum Season { Winter = 3, Spring = 6, Summer = 9, Fall = 12 }`

What is a tuple?
`Combines multiple values into a single bundle. Example: (double, double) point = (2, 4)`

How can you switch two number variables in one line? Switch contents of two variables?
`You can use tuple deconstruction. Example: double x = 4; double y = 5; (x, y) = (y, x);`

What is a class?
`An object that contains fields and methods and usually a constructor`

What is the difference between const and readonly?
`const is initialized at compile time, readonly allows the variable to be initialized either at compile time or runtime. `

What is the difference between a field and a property?
`Fields should be kept private. Properties have getters and setters and allow access to fields.`

How do you extend a class?
`Use a colon.                                                        Example: public class Dog : Animal {}`
`The derived class constructor extends the base constructor as well. Example: public Dog(DogBreed breed): base(string animalType) {}`

What does the abstract keyword mean?
`When used you have to override the method or class that it's used on.`
`Used in interfaces`
`Abstract members must have abstract classes`
`Abstract class can contain any members it wants though - not everything has to be abstract`

What is an interface?
`Defines the methods, properties, etc. that need to exist on any class that implements it.`
`Members are public and abstract automatically`

What is a struct?
`Similar to a class, just defines a simple data structure. Cannot be used in inheritance. Can have constructors, fields, methods, properties, etc.`

What is a record?
`object that is data-centric, immutable and has value semantics (equal if all members are equal)`
`cannot create static records`
`public record Person(string FirstName, string LastName);`

When to use a struct vs. class vs. record?
`Can your data type be a value type? Go with struct.`
`Does your data describe a value-like, immutable state? Go with record`
`Otherwise, go with class`

What are generics?
`Solve the problem of needing to make classes or methods that would differ only by the types they use`
`Example: the methods I made that change casing or if your types share the properties you need to access but not all the same props`
`public void Add(T newValue) {}`

What does the static keyword mean?
`Means the item is owned by the type itself rather than the instance. It's shared across all instances.`
`Classes, fields, methods, and constructors can be static. If a class is static, all members must be static`

What is a dictionary?
`data structure that allows you to store key-value pairs`
`Dictionary keys should not change`
`Dictionary<int, string> pets = new Dictionary<int, string>();`
`Add items: pets.Add(1007, "Snowy");`
`Access by key and iterate with foreach.`

How to check for null?
`if (x == null)`
`Use a null conditional operator.             Example: x?.DoStuff()`
`Allow null values to fall back to a default. Example: x ?? "empty"`

How do you check types?
`using 'GetType()' and 'typeof'. Example: if (obj1.GetType() == typeof(MyType))`
`using 'is' keyword.             Example: if (obj1 is Animal)`

What is boxing and unboxing?
`boxing = assigning a value type to a reference type variable, creates a box on the heap. Example: object myObject = 3`
`unboxing = extracting the contents of a box and copying them to a value type variable.   Example: int number = (int)myObject`

What is a Guid?
`A globally unique identifier`

What is IEnumerable<T>?
`An interface that is the basis of foreach loops; used on almost any collection type.`

What is StringBuilder?
`A less memory intense way to build strings a little at a time. Use when looping to create strings.`
`StringBuilder text = new StringBuilder();`
`text.Append(input)`

What is Nullable? The Nullable<T> Struct
`lets you pretend a value type can take on a null value. Attaches a bool (HasValue property) which tells you whether the value is legitimate.`

What is a namespace?
`A collection of related types. Can nest multiple classes under one namespace.`

What is a using statement/ using directive?
`Tells compiler which namespaces to look for for unqualified type names`

What is a local function?
`A function inside a function`

How do you define a method with a variable number of parameters?
`Using the 'params' keyword`
`Define: public void DoStuff(params string[] words) {}`
`Then call like this - DoStuff("a"); or "DoStuff("a", "b", "c");`

What is passing by reference?
`Allows two methods to share a variable and it's memory location directly.`
`Allows method to directly affect the calling method's variables, which is powerful but risky`
`Avoids costs of copying large value types when method is called`
`Define: public void DisplayNumber(ref int x) {}   Call: DisplayNumber(ref y);`

What is an output parameter?
`A method defines an out parameter using the 'out' keyword and that value is automatically returned by the method.`
`Example declaration: public void DoThing(out int value) { value = 22 };`
`Example Call:        double x; DoThing(out x); // Now x = 22`

What is an extension method?
`A static method that gives the appearance of being attached to another type as an instance method.`
`So you can extend one method to do more things`
`Use the 'this' keyword before the first parameter to make it an extension method.`

How do you define optional parameters in C#?
`Give them a default value. Example: public void DoSomething(int y = 3) {}`

How to maintain stack trace when throwing exception?
`If you rethrow an exception ('throw e'), you will reset the stack trace. However, just using 'throw' will maintain the trace and bubble the error up.`

What is a delegate?
`A variable that holds a reference to a method/function, allowing them to be passed around like simple data.`
`public delegate float NumberDelegate(float a, float b);`

What are events?
`Allows an object to notify others that something changed so they can respond`

What is a lambda expression?
`Lets you define short unnamed methods`
`Example: x => x < 5`
`Example with multiple params: (x, y) => x + y`
`Example with no params: () => Console.WriteLine("Yo Vanilla");`

What classes lets you work with files?
`System.IO.File`

What is operator overloading?
`Lets you redefine how certain operators work (+, -, *, /, %, ++, --, ==, !=, >=, <=, >, <)`
`Don't do this unless you have a very good reason to do so. Use methods instead - allows you to name what is happening`

What is multi-threading? multithreading
`Creating multiple threads allows you to do more than one thing at a time. Run multiple versions of your application`
`A *thread* is an independent execution path in a program`
`Each thread gets its own stack, but they all share the same heap (allowing them to share data)`

What is a deadlock? concurrency related issue
`When a thread is stuck waiting to acquire a lock but will never acquire it because another thread has aquired it and is stalled.`
`Metaphor: Imagine you need both a keyboard and mouse to do a job. I grab the keyboard and you grab the mouse. I'm waiting for you to be done with the mouse and you're waiting for me to be done with the keyboard. We will both wait forever.`

What is asynchronous programming?
`lets task run in the background. scheduling tasks to continue or callbacks to happen when the async task completes.`
`Task (no return value) and Task<T>(has return value) classes can be used to schedule tasks to run async.`
`You can 'await' an async task if your method has the 'async' keyword`

What is 'unsafe' code?
`Determined by explicitly using the 'unsafe' keyword.`
`Allows you to reference and manipulate memory locations directly`

What is IDisposable?
`It is used to release managed and unmanaged resources`
`Lets you run your own logic on an object before it's garbage collected.`
`Call Dispose() to clean up - can lead to memory leaks if you don't`

What is the difference between managed and unmanaged resources?
`Unmanaged resources are not directly under the control of the garbage collector`
`Unmanaged code is sometimes called "native code"`

What is a partial class?
`Allows slices of the class to be defined in separate files.`
`Use the 'partial' keyword to define`

What is reflection?
`used to retrieve metadata on types at runtime.`
`can use to explore all DLLs loaded in the program`
`Typically done by using the Type class (typeof or GetType())`
`Example: Type type = typeof(int) *OR* Type type = myObject.GetType();`

What is the yield keyword?
`The yield keyword returns each element of a collection one at a time.`
`Negates the need to create temporary collections`

What is NuGet?
`NuGet is a package manager.`
`Each NuGet package is in a .nupkg file (basically a zip file that contains the .dll and metadata)`
`NuGet allows you to configure projects to use specific versions of packages.`

What is a bit?
`A binary digit. 1 or 0`

What is a byte?
`8 bits`

What is a dynamic object?
`An object that can be defined at creation time and allows methods and properties to be added/removed as the program runs.`
`Built using the 'IDynamicMetaObjectProvider' interface, deriving from the 'DynamicObject' class, or using the 'ExpandoObject' class (ExpandoObject is the simplest).`
`Should stick to statically typed objects unless you have a good reason not to.`
`Can emulate dynamic objects with dictionaries instead.`

What is dynamic type checking?
`A variable is dynamically typed if it uses the 'dynamic' keyword. Example: dynamic text = "Hello World";`
`Variables including parameters and return types have no fixed type.`
`The compiler can't check if a given method call will work.`
`Should stick to statically typing your variables unless you have a good reason not to.`

What is a Pointer?
`Allows you to reference a specific memory address`
`Typically used in unsafe code`
`Declared by using a "*". Example: int* p; // A pointer to an integer`

What does a "Fixed" statement do?
`Lets you "pin" managed references in place so a Pointer can reference them`
`A "fixed-size array" or "fixed-size buffer" stores its data within a struct instead of on the heap (size of array remains same).`

What is a stack allocation?
`Placing an array's memory on the stack instead of the heap.`
`Done by using "stackalloc" keyword. Example: int* numbers = stackalloc int[10];`
`Only allowed in unsafe context, for local variables and only for unmanaged types`

What is "PIS" (also known as "P/Invoke")?
`Platform Invocation Services`
`Allows managed C# code to call native, unmanaged, non .NET code directly (including C & C++ libraries and OS calls).`