
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            var sentences = s.Split(new char[] { '.','?','!' });
            var longestSentence = 0;
            foreach (var sentence in sentences)
            {
                var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (words.Length > longestSentence)
                {
                    longestSentence = words.Length;
                }
            }
            return longestSentence;
        }
    }
}




