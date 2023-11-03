public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0) { }

    public void RunTheActivity()
    {
        TheWelcome();

        Console.Write("How long, in second, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;

        GetReady();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int d = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            for (int bi = 4; bi > 0; bi--)
            {
                Console.Write(bi);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Breath out...");
            for (int bo = 7; bo > 0; bo--)
            {
                Console.Write(bo);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            d++;
        }
        DisplaySpinner(5);
    }
}