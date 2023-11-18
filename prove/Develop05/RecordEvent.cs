using System.IO;

public class RecordEvent : Goal
{
    public RecordEvent() : base("") {}
    public void TheFunction(List<Goal> goals, ref int userScore, string filePath)
    {
        Console.WriteLine("The Goals are:");
        int lineNumber = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{lineNumber}{goal.GetName()}");
            lineNumber++;
        }

        Console.Write("Which goal did you accomplish? Enter the number: ");
        if (int.TryParse(Console.ReadLine(), out int completedTaskIndex))
            {
                if (completedTaskIndex > 0 && completedTaskIndex <= goals.Count)
                {
                    Goal completedGoal = goals[completedTaskIndex - 1]; // Get the completed goal

                    // Get the goal's current name
                    string goalInfo = completedGoal.GetName();

                    // Modify the goal's name to mark it as completed
                    goalInfo = goalInfo.Replace("[ ]", "[X]");

                    // Update the goal information in the list
                    completedGoal.SetName(goalInfo);

                    // Add points to userScore
                    string[] parts = goalInfo.Split(',');
                    if (parts.Length > 1)
                    {
                        string pointsPart = parts[parts.Length - 1].Trim();
                        if (pointsPart.EndsWith("pts"))
                        {
                            string pointsStr = pointsPart.Replace("pts", "").Trim();
                            if (int.TryParse(pointsStr, out int points))
                            {
                                userScore += points; // Add points to userScore
                            }
                        }
                    }

                // Display the updated goal and user score
                Console.WriteLine($"You accomplished: {goalInfo}");
                Console.WriteLine($"Updated user score: {userScore}");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
    }
    
}