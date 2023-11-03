public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.", 0) { }

    public void RunTheActivity()
    {
        TheWelcome();

        Console.Write("How long, in second, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;

        GetReady();

        List<string> _listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
	        "When have you felt the Holy Ghost this month?",
	        "Who are some of your personal heroes?"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int d = 0;
        while (DateTime.Now < endTime)
        {
            string GetListingPrompt()
            {
                Random random = new Random();
                int randomListingIndex = random.Next(0, _listingPrompts.Count);
                return _listingPrompts[randomListingIndex];
            }
            string SelectedListing = GetListingPrompt();
            Console.WriteLine(SelectedListing);
            string listinginput = Console.ReadLine();
        d++;
        }
        DisplaySpinner(5);
    }
}