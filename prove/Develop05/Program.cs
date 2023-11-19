using System.Collections.Generic;

using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int userScore = 0;
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine($"\nYou have {userScore} points.");
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
                Console.WriteLine("\nThe type of Goals are:");
                Console.WriteLine("1, Simple Goal");
                Console.WriteLine("2, Eternal Goal");
                Console.WriteLine("3, Checklist Goal");
                Console.Write("Which type pf goal would you like to create? ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.TheFunction();
                    goals.Add(new Goal(simpleGoal.GetNewGoal()));
                }

                else if (choice == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.TheFunction();
                    goals.Add(new Goal(eternalGoal.GetNewGoal()));
                }

                else if (choice == "3")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.TheFunction();
                    goals.Add(new Goal(checklistGoal.GetNewGoal()));
                }

                else
                {
                    Console.WriteLine("Invalid. Please enter 1, 2 or 3");
                }
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
                LoadGoals loadGoals = new LoadGoals();
                loadGoals.TheFunction(goals);
                goals.Add(new Goal(loadGoals.GetNewGoal()));
            }

            else if (input == "5")
            {
                RecordEvent recordEvent = new RecordEvent();
                recordEvent.TheFunction(goals, ref userScore, "");
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