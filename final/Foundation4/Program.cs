using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new Activity[]
        {
            new Running(DateTime.Now, 30, 3.0),
            new Cycling(DateTime.Now, 45, 20.0),
            new Swimming(DateTime.Now, 60, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}