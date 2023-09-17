using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string number;
        int answer;
        Console.Write("What is the magic number? ");
        number = Console.ReadLine();
        answer = Convert.ToInt32(number);


        string guess;
        int guessnumber;
        
        Console.Write("What is your guess?");
        guess = Console.ReadLine();
        guessnumber = Convert.ToInt32(guess);
        
        if (guessnumber > answer)
        {
            Console.WriteLine("Lower");
        }
        else if (guessnumber < answer)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

    }
}