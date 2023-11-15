using System;

public class EternalGoal : Goal
{
    public EternalGoal() : base("") {}
    
    public void TheFunction()
    {
        Console.Write("\nWhat is the name of your goal? ");
        string goalName = Console.ReadLine();
                    
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
                    
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        int lineNumber;
        string[] existingLines;

        if (File.Exists(fileName))
        {
            existingLines = File.ReadAllLines(fileName);
            lineNumber = existingLines.Length + 1;
        }
        else
        {
            lineNumber = 1;
        }
        newEternalGoal = lineNumber + " [ ] " + goalName +" : "+ goalDescription +", "+ points + " points";
        Console.WriteLine("A new goal created.");
    }
    public string GetNewGoal()
    {
        return newEternalGoal;
    }
}