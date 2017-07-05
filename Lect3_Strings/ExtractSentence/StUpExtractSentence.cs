using System;

namespace ExtractSentence
{
    class StUpExtractSentence
    {
        static void Main()
        {
            string searchedWord = Console.ReadLine();
            string text = Console.ReadLine();

            int startSeq = int.MinValue;
            int endSeq = int.MinValue;

            //while (text.IndexOf(" " + searchedWord + " ") != -1)
            //{
                int word = text.IndexOf(" " + searchedWord + " ");
                startSeq = text.LastIndexOf('.', word);
                endSeq = text.IndexOf('.', word);

                if (startSeq == -1)
                {
                    startSeq = 0;
                }
            //}
            Console.Write(text.Substring(startSeq, endSeq - startSeq + 1));

        }
    }
}
