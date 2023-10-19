# Detailed Standard Input/Output Functions and Variable Definitions

In C#, standard input and output are typically handled through the `Console` class, which provides various methods for interacting with the console. This guide covers standard input/output functions and variable definitions in C#.

## Standard Input/Output Functions

### Reading from Standard Input

- **Console.ReadLine():** Reads a line of text from the standard input, usually the keyboard.
```csharp
   string input = Console.ReadLine();
```

### Writing to Standard Output

- **Console.Write():** Writes text to the standard output without a newline character.
```csharp
Console.Write("Hello, ");
```

- **Console.WriteLine():** Writes text to the standard output with a newline character, moving the cursor to the next line.
```csharp
Console.WriteLine("World!");
```

## Variable Definitions

In C#, variables are used to store and manipulate data. Before using a variable, you need to declare and define it. Here are some common data types and variable definitions:

### Integer Variables

- **int:** Represents 32-bit signed integers.
```csharp
int age = 19;
```

### Floating-Point Variables

- **double:** Represents 64-bit double-precision floating-point numbers.
```csharp
double price = 25.98;
```

### String Variables

- **string:** Represents a sequence of characters.
```csharp
string name = "Alf";
```

### Character Variables

- **char:** Represents a single character.
```csharp
char gender = 'M';
char gender = 'Male';
```
