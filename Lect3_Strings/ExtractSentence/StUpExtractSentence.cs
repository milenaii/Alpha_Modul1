using System;
// 20t bgcoder
namespace ExtractSentence
{
    class StUpExtractSentence
    {
        static void Main()
        {
            string searchedWord = Console.ReadLine();
            string text = Console.ReadLine();
            //text = text.ToUpper();
            //searchedWord = searchedWord.ToUpper();

            string [] sentence = text.Trim().Split(new[] {"."},StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i].Contains(" "+ searchedWord +" ") || sentence[i].Contains(" " + searchedWord + ", ") || sentence[i].Contains(" "+ searchedWord + ":") || sentence[i].Contains(" " + searchedWord + ";") || sentence[i].Contains("\"" + searchedWord + "\"") || sentence[i].Contains(" " + searchedWord + "\"") || sentence[i].Contains("\"" + searchedWord + " ") || sentence[i].Contains("(" + searchedWord + ")") || sentence[i].Contains("(" + searchedWord + " ") || sentence[i].Contains(" " + searchedWord + ")"))
                {
                    Console.Write(sentence[i] + ".");
                }
            }

        }
    }
}
