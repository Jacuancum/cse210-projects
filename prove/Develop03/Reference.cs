using System;
using System.Collections.Generic;

class Reference
{
    private List<Scripture> _verses;

    public Reference()
    {
        _verses = new List<Scripture>();
    }

    public void AddVerse(Scripture verse)
    {
        _verses.Add(verse);
    }

    public void DisplayAllVerses()
    {
        foreach (var verse in _verses)
        {
            verse.Display();
        }
    }
}