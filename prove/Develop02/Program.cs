using System;
using RandomQuestionGenerator;

public class Journal
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome back to your journal.");
        string answer;
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
                //Console.WriteLine(dateText);
                Console.WriteLine(randomQuestion);
            else if (answer == "2")
                Console.WriteLine("OUT OF SERVICE");
            else if (answer == "5")
                break;
        }
        Console.WriteLine("See you next time.");
    }
    
}
    
