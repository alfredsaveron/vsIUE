using System;

class ArithmeticOperatorsExample
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 5;

        // Addition (+)
        int sum = num1 + num2;
        Console.WriteLine($"Addition: {num1} + {num2} = {sum}");

        // Subtraction (-)
        int difference = num1 - num2;
        Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");

        // Multiplication (*)
        int product = num1 * num2;
        Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

        // Division (/)
        int quotient = num1 / num2; // Integer division
        Console.WriteLine($"Division (Integer): {num1} / {num2} = {quotient}");

        // Division (/) with floating-point result
        double divisionResult = (double)num1 / num2;
        Console.WriteLine($"Division (Floating-Point): {num1} / {num2} = {divisionResult}");

        // Modulus (%)
        int remainder = num1 % num2;
        Console.WriteLine($"Modulus: {num1} % {num2} = {remainder}");
    }
}
