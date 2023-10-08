using System;

namespace RandomQuestionGenerator
{
    public class PromptQuestion
    {
        private static string[] _questions = 
        {"What was the best part of my day?",
         "How did I see the hand of the Lord in my life today?", 
         "What was the strongest emotion I felt today?", 
         "If I had one thing I could do over today, what would it be?", 
         "Who was the most interesting person I interacted with today?", 
         "What did you eat today?",
         "What do you want to improve today if you can do it again?",
         "Where have you been today?",
         "How was the weather today?"};

        public static string _randomQuesionsPrompt()
        {
            var rand = new Random();
            string randomQuestion = _questions[rand.Next(_questions.Length)];

            return randomQuestion;
        }
    }
}
