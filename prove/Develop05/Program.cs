using System;

class Program
{
    static List<BaseGoal> goals = new List<BaseGoal>();
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("You have X points.");
            Console.WriteLine("1, Create New Goal");
            Console.WriteLine("2, List Goals");
            Console.WriteLine("3, Save Goals");
            Console.WriteLine("4, Load Goals");
            Console.WriteLine("5, Record Event");
            Console.WriteLine("6, Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                CreateNewGoal.TheFunction(goals);
            }

            else if (input == "2")
            {
                ListGoals.ThesFunction(goals);
            }

            else if (input == "3")
            {
                Console.Write("What is the file name for the goal file? ");
            }

            else if (input == "4")
            {
                Console.Write("What is the file name for the goal file? ");
            }

            else if (input == "5")
            {
                Console.WriteLine("The Goals are:");
                Console.Write("Which goal did you accomplish? ");
                Console.WriteLine("Congratulations! You have earned X points.");
            }

            else if (input == "6")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid. Please enter 1, 2, 3, 4, 5 or 6.");
            }
        }
        Console.WriteLine("See you next time.");
    }
}