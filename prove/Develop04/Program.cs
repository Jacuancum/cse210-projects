using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Option:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice form the menu: ");
            string input = Console.ReadLine();
            if (input == "4")
            {
                break;
            }
            else if (input == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunTheActivity();
            }
            else if (input == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity(prompts, questions);
                reflectingActivity.RunTheActivity();
            }
            else if (input == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunTheActivity();
            }
            else
            {
                Console.WriteLine("Invalid. Please enter 1, 2, 3 or 4.");
            }
        }
        Console.WriteLine("See you next time.");
    }
}