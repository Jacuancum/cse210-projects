using System.Runtime.CompilerServices;

public class ListGoals : Goal
{
    public ListGoals() : base("") {}
    public static void TheFunction(List<Goal> goals)
    {
        Console.WriteLine("\nThe Goals are:");
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
        }
        else
        {
            int lineNumber = 1;
            foreach (Goal goal in goals)
            {
                Console.WriteLine($"{lineNumber}{goal.GetName()}");
                lineNumber++;
            }
        }
    }
}