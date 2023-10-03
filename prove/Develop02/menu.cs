using System;

using RandomQuestionGenerator;

public class Menu
{
    public void Display()
    {
        var randomQuestion = PromptQuestion._randomQuesionsPrompt();
        Console.WriteLine(randomQuestion);
    }
}
