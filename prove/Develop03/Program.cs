using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Scripture verse1 = new Scripture
        ("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        
        //Clear the screen
        Console.Clear();
        
        //Show the scripture
        Reference reference = new Reference();
        reference.AddVerse(verse1);
        reference.DisplayAllVerses();

        //A while loop continue to hide words when user press Enter
        while (!verse1.AllWordsHidden())
        {
            Console.WriteLine("\nPress Enter to hide words or enter 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            
            //Keep the screen show one scripture only
            Console.Clear();
            verse1.HideWords(2);
            reference.DisplayAllVerses();
        }

    }
}