using System;

class ArithmeticOperatorsExample
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 5;

        // (+)
        int sum = num1 + num2;
        Console.WriteLine($"Addition: {num1} + {num2} = {sum}");

        // (-)
        int difference = num1 - num2;
        Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");

        // (*)
        int product = num1 * num2;
        Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

        // (/)
        int quotient = num1 / num2; // Integer division
        Console.WriteLine($"Division (Integer): {num1} / {num2} = {quotient}");

        // Division (/) with floating-point result
        double divisionResult = (double)num1 / num2;
        Console.WriteLine($"Division (Floating-Point): {num1} / {num2} = {divisionResult}");

        // (%)
        int remainder = num1 % num2;
        Console.WriteLine($"Modulus: {num1} % {num2} = {remainder}");
    }
}
