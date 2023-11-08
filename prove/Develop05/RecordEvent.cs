public class RecordEvent : Goal
{
    public RecordEvent() : base("") {}
    public static void TheFunction(List<Goal> goals, ref int userScore)
    {
        Console.WriteLine("The Goals are:");
        Console.Write("Which goal did you accomplish? ");
        Console.WriteLine("Congratulations! You have earned X points.");
    }
}