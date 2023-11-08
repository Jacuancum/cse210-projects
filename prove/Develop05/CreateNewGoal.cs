public class CreateNewGoal : Goal
{
    public CreateNewGoal() : base("") {}

    public static void TheFunction(List<Goal> goals)
    {
        Console.WriteLine("\nThe type of Goals are:");
        Console.WriteLine("1, Simple Goal");
        Console.WriteLine("2, Eternal Goal");
        Console.WriteLine("3, Checklist Goal");
        Console.Write("Which type pf goal would you like to create? ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.Write("\nWhat is the name of your goal? ");
            string simpleGoalName = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(simpleGoalName);
            goals.Add(simpleGoal);
            Console.Write("What is a short description of it? ");
            Console.Write("What is the amount of points associated with this goal? ");
        }

        else if (choice == "2")
        {
            Console.Write("What is the name of your goal? ");
        }

        else if (choice == "3")
        {
            Console.Write("What is the name of your goal? ");
        }

        else
        {
            Console.WriteLine("Invalid. Please enter 1, 2 or 3");
        }
    }
}