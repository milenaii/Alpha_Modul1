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


            string[] sentence = text.Trim().Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in sentence)
            {
                for (int i = 0; i < sentence.Length; i++)
                {

                }
            }

        }
    }
}
