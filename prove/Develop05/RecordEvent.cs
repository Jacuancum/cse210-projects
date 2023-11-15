public class RecordEvent : Goal
{
    public RecordEvent() : base("") {}
    public static void TheFunction(List<Goal> goals, ref int userScore)
    {
        Console.WriteLine("The Goals are:");
        string filePath = "goals.txt";
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        Console.Write("Which goal did you accomplish? ");
        int completedTaskIndex = int.Parse(Console.ReadLine()) - 1;
        if (completedTaskIndex >= 0 && completedTaskIndex < lines.Length)
        {
            lines[completedTaskIndex] = $"[X] {lines[completedTaskIndex].Substring(4)}";
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("The task is completed. Congratulations! You have earned X points.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}