using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello SB World!!!");
        Console.WriteLine("This is in C#.");

        Console.Write("What color? ");
        string color = Console.ReadLine();
        Console.WriteLine("Your color is " + color + ".");
        Console.WriteLine($"Your color is {color}.");
    }
}