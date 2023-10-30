using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment one = new Assignment("Yellow Umbrella", "Philosophy");
        Console.WriteLine(one.GetSummary());

        
        MathAssignment two = new MathAssignment("John Locke", "Introduction to Liberalism", "6.4", "19-84");
        Console.WriteLine(two.GetSummary());
        Console.WriteLine(two.GetHomeworkList());

        WritingAssignment three = new WritingAssignment("Karl Marx", "Disadvantages of Communism", "Chinese Cultural Revolution");
        Console.WriteLine(three.GetSummary());
        Console.WriteLine(three.GetWritingInformation());
    }
}