## Operation Priorities

In **C#**, arithmetic operators have predefined priorities that determine the order in which they are evaluated in an expression. Here's the general order of operation priorities, from highest to lowest:

- **`Parentheses`**: Operations enclosed in parentheses have the highest priority and are evaluated first. You can use parentheses to control the order of operations.
- **`Multiplication (*), Division (/), and Modulus (%)`**: These operators have the second-highest priority and are evaluated from left to right.
- **`Addition (+) and Subtraction (-)`**: Addition and subtraction operators have the lowest priority and are evaluated from left to right.

```csharp
int result = 10 + 5 * 2;  // Multiplication is performed first: 10 + (5 * 2) = 20
```

```csharp
int result = (10 + 5) * 2;  // Addition is performed first: (10 + 5) * 2 = 30
```
