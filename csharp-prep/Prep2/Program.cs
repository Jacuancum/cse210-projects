using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        string percentage;
        int grade;
        Console.Write("What is your grade percentage? ");
        percentage = Console.ReadLine();
        grade = Convert.ToInt32(percentage);
        
        if (grade >= 90)
        {
            Console.WriteLine($"Your grade is A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"Your grade is B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"Your grade is C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"Your grade is D.");
        }
        else
        {
            Console.WriteLine($"Your grade is F.");
        }


        if (grade >=70)
        {
            Console.WriteLine("Congratulation! Your pass the class.");
        }
        else
        {
            Console.WriteLine("You didn't pass this time. Try again. Never give up.");
        }
    }
}