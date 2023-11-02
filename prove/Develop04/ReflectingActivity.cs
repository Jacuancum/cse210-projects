public class ReflectingActivity : Activity
{
    public ReflectingActivity(int duration) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", duration) { }

    public void RunTheActivity()
    {
        Console.Clear();
        Console.WriteLine("");
    }
}