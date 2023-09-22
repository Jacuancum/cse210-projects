using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        /*
        List<int> numbers = new List<int>();
        numbers.Add(7);
        numbers.Add(5);
        Console.WriteLine($"The number count: {numbers.Count}");
        */
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        string number;
        int numbergiven;
        do {
        Console.Write("Enter number: ");
        number = Console.ReadLine();
        numbergiven = Convert.ToInt32(number);
        numbers.Add(numbergiven);
        }while (numbergiven != 0);
        
        /*
        int max;
        foreach {
            if (numbergiven > max) {
                max = numbergiven;
            }
        }
        */

        int Count = numbers.Count -1;
        Console.WriteLine($"The numbers count is: {Count}");
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        //Console.WriteLine($"The largest number is: {numbers.max()}");

    }
}