using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int userScore = 0;
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("\nYou have X points.");
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
                ListGoals.TheFunction(goals);
            }

            else if (input == "3")
            {
                SaveGoals.TheFunction(goals);
            }

            else if (input == "4")
            {
                LoadGoals.TheFunction(goals);
            }

            else if (input == "5")
            {
                RecordEvent.TheFunction(goals,ref userScore);
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