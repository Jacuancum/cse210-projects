using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new Activity[]
        {
            new Running(DateTime.Now, 30, 3.0),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}