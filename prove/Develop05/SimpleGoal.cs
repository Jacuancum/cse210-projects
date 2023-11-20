using System;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal() : base("") {}
    public void TheFunction()
    {
        Console.Write("\nWhat is the name of your goal? ");
        string goalName = Console.ReadLine();
                    
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
                    
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        _newSimpleGoal = " [ ] " + goalName +" : "+ goalDescription +", "+ points + " pts";
        Console.WriteLine("A new goal created.");
        
    }
    
}