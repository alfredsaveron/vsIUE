# C# Language: Detailed Arithmetic Operators and Operation Priorities

In C#, arithmetic operators are used to perform basic mathematical operations on numerical values. This guide provides comprehensive information about arithmetic operators and their operation priorities.

## Arithmetic Operators

Arithmetic operators in C# are used to manipulate numerical values. Here are the common arithmetic operators:

- **Addition (+):**
  - Description: Adds two values.
  - ``Example:``

    ```csharp
    int sum = 5 + 3;  // 8
    ```

- **Subtraction (-):**
  - Description: Subtracts the right operand from the left operand.
  - ``Example:``

    ```csharp
    int difference = 10 - 5;  // 5
    ```

- **Multiplication (*):**
  - Description: Multiplies two values.
  - ``Example:``

    ```csharp
    int product = 4 * 3;  // 12
    ```

- **Division (/):**
  - Description: Divides the left operand by the right operand (integer division).
  - ``Example:``

    ```csharp
    int quotient = 10 / 2;  // 5
    ```

- **Division with Floating-Point Result (/):**
  - Description: Divides the left operand by the right operand, resulting in a floating-point number.
  - ``Example:``

    ```csharp
    double divisionResult = 10.0 / 3.0;  // 3.333...
    ```

- **Modulus (%):**
  - Description: Returns the remainder of the division of the left operand by the right operand.
  - ``Example:``

    ```csharp
    int remainder = 10 % 3;  // 1
    ```

- **Increment (++) and Decrement (--):**
  - Description: Increases or decreases the value of a variable by 1.
  - ``Example:``

    ```csharp
    int x = 5;
    x++;  // x is now 6
    x--;  // x is back to 5
    ```

## Operation Priorities

C# follows the standard order of operations, also known as BODMAS/BIDMAS, for arithmetic expressions. Here's the general order of operation priorities, from highest to lowest:

1. **``Parentheses:``** Operations enclosed in parentheses have the highest priority and are evaluated first. You can use parentheses to control the order of operations.

2. **``Multiplication (*), Division (/), and Modulus (%):``** These operators have the second-highest priority and are evaluated from left to right.

3. **``Addition (+) and Subtraction (-):``** Addition and subtraction operators have the lowest priority and are evaluated from left to right.
