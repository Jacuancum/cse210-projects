using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 0) { }

    public void RunTheActivity()
    {
        TheWelcome();

        Console.Write("How long, in second, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;

        
        Console.WriteLine("Please get ready in 5 seconds:");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Start");
        Thread.Sleep(1000);

        List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        string GetPrompt()
        {
        Random random = new Random();
        int randomPromptIndex = random.Next(0, _prompts.Count);
        return _prompts[randomPromptIndex];
        }
        string GetRandomQuestion()
        {
        Random random = new Random();
        int randomQuestionIndex = random.Next(0, _questions.Count);
        return _questions[randomQuestionIndex];
        }

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        string selectedPrompt = GetPrompt();
        Console.WriteLine("--- " + selectedPrompt + " ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);
        DisplaySpinner(5);
    }
}