using System;

class Scripture
{
    private string _reference;
    private string _text;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}\n");
        Console.WriteLine(_text);
    }

    public void HideWords(int wordCount)
    {
        //Cut down the long scripture and put into a []
        string[] words = _text.Split(' ');
        wordCount = 2;
        Random random = new Random();
        int randomIndex;
                
        //Change a random word become _
        do
        {
            randomIndex = random.Next(words.Length);
        } while (words[randomIndex].Contains('_'));

        words[randomIndex] = new string('_', words[randomIndex].Length);
        _text = string.Join(" ", words);
        
    }

    public bool AllWordsHidden()
    {
        return !_text.Contains(' ');
    }
}