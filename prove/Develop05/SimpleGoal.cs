using System;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal() : base("") {}

    public static int lineNumber = 1;
    public void TheFunction()
    {
        Console.Write("\nWhat is the name of your goal? ");
        string goalName = Console.ReadLine();
                    
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
                    
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        newSimpleGoal = lineNumber + " [ ] " + goalName +" : "+ goalDescription +", "+ points + " points";
        Console.WriteLine("A new goal created.");

        lineNumber++;
    }
    public int GetLineNumber()
    {
        return lineNumber - 1;
    }
    public string GetNewGoal()
    {
        return newSimpleGoal;
    }
}