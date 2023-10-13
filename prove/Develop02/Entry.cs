using System;

public class Entry
{
    public string DataEntry { get; set; }
    public string RandomQuestion { get; set; }

    public Entry(string dataEntry, string randomQuestion)
    {
        DataEntry = dataEntry;
        RandomQuestion = randomQuestion;
    }

    public void Display()
    {
        Console.WriteLine(DataEntry);
    }

    /*public override string ToString()
    {
        return DataEntry;
    }*/
}