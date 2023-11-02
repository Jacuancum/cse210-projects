public class ReflectingActivity : Activity
{
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 0) { }

    public void RunTheActivity()
    {
        Console.Clear();
        Console.WriteLine("Hello");
    }
}