using System;

public class Activity
{
    protected string ActivityName { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public Activity(string activityName, string description, int duration)
    {
        ActivityName = activityName;
        Description = description;
        Duration = duration;
    }
    
    public void DisplaySpinner(int seconds)
    {
        string spinnerChars = "-\\|/";
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write(spinnerChars[i % spinnerChars.Length]);
            System.Threading.Thread.Sleep(200);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.WriteLine();
    }
}