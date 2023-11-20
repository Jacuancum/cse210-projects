using System;

public class ChecklistGoal : Goal
{
    public ChecklistGoal() : base("") {}
    
    public void TheFunction()
    {
        Console.Write("\nWhat is the name of your goal? ");
        string goalName = Console.ReadLine();
                    
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
                    
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        Console.Write("How many times does this goal need to be accomplished? ");
        string numberoftime = Console.ReadLine();

        _newChecklistGoal = " [ ] " + goalName +" : "+ goalDescription +", "+ points + " pts," + numberoftime;
        Console.WriteLine("A new goal created.");
    }
    
    public override string GetNewGoal()
    {
        return _newChecklistGoal;
    }
}