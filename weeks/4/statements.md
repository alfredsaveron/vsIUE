# C# Language: Conditional Statements (if-else)

Conditional statements in C# allow you to make decisions in your code based on specific conditions. The `if-else` statement is one of the most commonly used conditional statements in C#. This guide provides a detailed explanation of how to use `if-else` statements in your C# code.

## `if` Statement

The `if` statement is used to execute a block of code only if a specified condition is true.

```csharp
int age = 25;
if (age >= 18)
{
    // When the condition is true
    Console.WriteLine("Adult.");
}
```

## `if-else` Statement

The `if-else` statement allows you to execute one block of code when a condition is true and another block of code when the condition is false.

```csharp
int age = 15;
if (age >= 18)
{
    // When the condition is true
    Console.WriteLine("Adult.");
}
else
{
    // When the condition is false
    Console.WriteLine("Not Adult.");
}

```
