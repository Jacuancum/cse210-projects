using System;
using System.IO;
using RandomQuestionGenerator;

public class Journal
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome back to your journal.");
        string answer;
        string journalFileName = "journal.txt";
        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            
            var randomQuestion = PromptQuestion._randomQuesionsPrompt();
            
            if (answer == "1")
            {   
                Console.WriteLine("[" + dateText + "]");
                Console.WriteLine(randomQuestion);
                string dataEntry;
                dataEntry = Console.ReadLine();
                string journalEntry = "[" + dateText + "]\n" + randomQuestion + "\n" + dataEntry;
                using (StreamWriter writer = File.AppendText(journalFileName))
                {
                    writer.WriteLine(journalEntry);
                }
            }
            else if (answer == "2")
            {
                Console.WriteLine("Your journal:");
                string[] journalEntries = File.ReadAllLines(journalFileName);
                foreach(var entry in journalEntries)
                {
                    Console.WriteLine(entry);
                }
            }    
            else if (answer == "3")
            {
                Console.WriteLine("OUT OF SERVICE");
            }
            else if (answer == "4")
            {
                Console.WriteLine("OUT OF SERVICE");
            }
            else if (answer == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid. Please entry 1, 2, 3, 4, or 5.");
            }
        }
        Console.WriteLine("See you next time.");
    }

}