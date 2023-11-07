public class CreateNewGoal : BaseGoal
{
    public CreateNewGoal() : base("") {}

    public static void TheFunction(List<BaseGoal> goals)
    {
        Console.WriteLine("\nThe type of Goals are:");
        Console.WriteLine("1, Simple Goal");
        Console.WriteLine("2, Eternal Goal");
        Console.WriteLine("3, Checklist Goal");
        Console.Write("Which type pf goal would you like to create? ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.WriteLine("");
        }

        else if (choice == "2")
        {
            Console.WriteLine("");
        }

        else if (choice == "3")
        {
            Console.WriteLine("");
        }

        else
        {
            Console.WriteLine("Invalid. Please enter 1, 2 or 3");
        }
    }
}