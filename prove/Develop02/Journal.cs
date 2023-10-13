using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private string journalFileName;
    public Journal(string fileName)
    {
        journalFileName = fileName;
    }

    public void AddEntry(string dataEntry, string randomQuestion, string date)
    {
        string journalEntry = "Date: " + date + " - Prompt: " + randomQuestion + "\n" + dataEntry;
        using (StreamWriter writer = File.AppendText(journalFileName))
        {
            writer.WriteLine(journalEntry);
        }
    }

    public void DisplayEntries()
    {
        string[] journalEntries = File.ReadAllLines(journalFileName);
        foreach (var entry in journalEntries)
        {    
            if (entry.StartsWith("Date: ") || entry.StartsWith("["))
            {
                Console.WriteLine();
            }
        Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = File.AppendText(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        // Implement loading entries from a file here.
    }
}