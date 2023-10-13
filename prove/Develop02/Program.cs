using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome back to your journal.");
        string answer;
        string journalFileName = "journal.txt";

        Journal journal = new Journal(journalFileName);

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Please pick one choice:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.WriteLine("Date: " + DateTime.Now.ToShortDateString());
                string randomQuestion = PromptGenerator.GetRandomQuestion();
                Console.WriteLine(randomQuestion);
                string dataEntry = Console.ReadLine();
                journal.AddEntry(dataEntry, randomQuestion, DateTime.Now.ToShortDateString());
            }
            else if (answer == "2")
            {
                journal.DisplayEntries();
            }
            else if (answer == "3")
            {
                Console.WriteLine($"Journal from file: {journalFileName}");
                journal.LoadFromFile(journalFileName);
            }
            else if (answer == "4")
            {
                Console.Write("Option 1: Save to current journal file.\nOption 2: Create a new file.\nWhat would you like to do? ");
                string saveOption = Console.ReadLine();

                if (saveOption == "1")
                {
                    journal.SaveToFile(journalFileName);
                    Console.WriteLine("Journal saved in the current file.");
                }
                else if (saveOption == "2")
                {
                    Console.Write("Enter a new file name (e.g., Day2.txt): ");
                    string newFileName = Console.ReadLine();
                    journal.SaveToFile(newFileName);
                    Console.WriteLine($"Journal saved in {newFileName}.");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter 1 or 2.");
                }
            }
            else if (answer == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid. Please enter 1, 2, 3, 4, or 5.");
            }
        }
        Console.WriteLine("See you next time.");
    }
}