using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name or username: ");
        string name = Console.ReadLine(); // Read a line of text from the user
        Console.WriteLine($"Hai, {name}!");
    }
}
