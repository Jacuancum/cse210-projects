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

        newEternalGoal = " [ ] " + goalName +" : "+ goalDescription +", "+ points + " pts";
        Console.WriteLine("A new goal created.");
    }
    public string GetNewGoal()
    {
        return newEternalGoal;
    }
}