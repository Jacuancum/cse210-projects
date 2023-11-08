public class SaveGoals : Goal
{
    public SaveGoals() : base("") {}
    
    public static void TheFunction(List<Goal> goals)
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = File.AppendText(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetName());
            }
        }

    }
}