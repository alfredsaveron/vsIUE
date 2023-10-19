# Standard Input/Output Functions and Variable Definitions

In C#, you can work with standard input and output, as well as define variables, using the `Console` class. Here's an overview of how to use standard input/output functions and define variables in C#.

## Standard Input/Output Functions

### Reading from Standard Input (`Console.ReadLine()`)
To read input from the user, you can use the `Console.ReadLine()` method. It reads a line of text entered by the user and returns it as a string.

```csharp
Console.Write("Enter your name or username: ");
string name = Console.ReadLine();
```

### Writing to Standard Output (`Console.WriteLine()`)
You can display output to the console using the `Console.WriteLine()` method. It prints a string to the console followed by a newline character.

```csharp
int age = 25;
Console.WriteLine($"Your age's: {age}");
```

## Variable Definitions

In **C#**, variables must be defined with a data type before using them. Here are some common data types used for variable definitions:

- `int`: Represents integer values.
- `double`: Represents double-precision floating-point numbers.
- `string`: Represents a sequence of characters.
- `char`: Represents a single character.
- `bool`: Represents a Boolean value (T or F).

```csharp
int age = 19;
double price = 20,20;
string name = "Alfred";
char gender = 'M';
bool isStudent = true;
```
