using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("2 Cornwall Street", "Kowloon Tong", "Hong Kong", "China");
        Address address2 = new Address("10 Purple Park Ave", "Beautiful City", "Osaka", "Japan");
        Address address3 = new Address("490 King Road", "Victory Town", "Lantau Island", "Hong Kong");

        Lecture lecture = new Lecture("Lecture Event", "Electronic device and kids", DateTime.Now, "2:00 PM", address3, "Dr Jacob Chan", 120);
        Reception reception = new Reception("Reception Event", "Ho Dao College Reunion", DateTime.Now, "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Gathering Event", "The full moon night", DateTime.Now, "8:00 PM", address1, "Sunny");

        //Call the three types activities and the three different methods
        //Create indent by using spaces
        //Using "-" to make a long line to separate them
        Console.WriteLine("Lecture Event:");
        Console.WriteLine("  Standard details:");
        Console.WriteLine("    " + lecture.GenerateStandardDetails());
        Console.WriteLine("----------------------------");
        Console.WriteLine("  Full details:");
        Console.WriteLine("    " + lecture.GenerateFullDetails());
        Console.WriteLine("----------------------------");
        Console.WriteLine("  Short description:");
        Console.WriteLine("    " + lecture.GenerateShortDescription());

        Console.WriteLine("\nReception Event:");
        Console.WriteLine("  Standard details:");
        Console.WriteLine("    " + reception.GenerateStandardDetails());
        Console.WriteLine("----------------------------");
        Console.WriteLine("  Full details:");
        Console.WriteLine("    " + reception.GenerateFullDetails());
        Console.WriteLine("----------------------------");
        Console.WriteLine("  Short description:");
        Console.WriteLine("    " + reception.GenerateShortDescription());

        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine("  Standard details:");
        Console.WriteLine("    " + outdoorGathering.GenerateStandardDetails());
        Console.WriteLine("----------------------------");
        Console.WriteLine("  Full details:");
        Console.WriteLine("    " + outdoorGathering.GenerateFullDetails());
        Console.WriteLine("----------------------------");
        Console.WriteLine("  Short description:");
        Console.WriteLine("    " + outdoorGathering.GenerateShortDescription());
    }
}