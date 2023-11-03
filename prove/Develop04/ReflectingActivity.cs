using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    public ReflectingActivity(List<string> prompts, List<string> questions) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 0) { }

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
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");

        string selectedPrompt = GetPrompt();
        Console.WriteLine("---" + selectedPrompt + "---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);
        DisplaySpinner(5);
    }
}