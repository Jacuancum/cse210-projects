using System.IO;
using System.Text;

namespace RandomQuestionGenerator
{
    public class PromptQuestion
    {
        public static string[] _questions = {"a", "b", "c", "d", "e", "f"};

        public static string _randomQuesionsPrompt()
        {
            var rand = new Random();
            string randomQuestion = _questions[rand.Next(_questions.Length)];

            return $"{_questions}";
        }
    }
}
