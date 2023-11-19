using System;
using System.IO;
using System.Collections.Generic;

public class LoadGoals : Goal
{
    public LoadGoals() : base("") {}

    public void TheFunction(List<Goal> goals)
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            if (lines.Length > 0)
            {
                Console.WriteLine("Content of the file:");
                int lineNumber = 1;
                foreach (string line in lines)
                {
                    Console.WriteLine($"{lineNumber} {line}");
                    lineNumber++;
                }
            }
            _result = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("There is no text file exist.");
        }
    }
    public override string GetNewGoal()
    {
        return _result;
    }
}