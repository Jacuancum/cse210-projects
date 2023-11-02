using System;

public class Activity
{
    protected string _activityName { get; set; }
    protected string _description { get; set; }
    protected int _duration { get; set; }

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    
    public void DisplaySpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            //Console.Write(".");
            //Thread.Sleep(1000);
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            //because only 0-3 things in the list, index 4 is a problem
            if ( i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine("Well Done!!");
        Console.WriteLine();
        Thread.Sleep(1500);
    }
}