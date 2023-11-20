public class SaveGoals : Goal
{
    public SaveGoals() : base("") {}

    public static void TheFunction(List<Goal> goals)
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        // Get the goal information from the List<Goal>
        List<string> goalLines = new List<string>();
        foreach (Goal goal in goals)
        {
            goalLines.Add(goal.GetName()); // GetName returns the goal information
        }

        if (File.Exists(fileName))
        {
            // Append goal lines to the existing file
            File.AppendAllLines(fileName, goalLines);
            Console.WriteLine("Goals added to the existing file.");
        }
        else
        {
            // Create a new file and write the goal lines
            File.WriteAllLines(fileName, goalLines);
            Console.WriteLine("Goals saved to a new file.");
        }
    }
}