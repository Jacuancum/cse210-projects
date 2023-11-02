using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
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

            }
            else if (input == "3")
            {

            }
            else
            {
                Console.WriteLine("Invalid. Please enter 1, 2, 3 or 4.");
            }
        }
        Console.WriteLine("See you next time.");
    }
}