using System;

namespace ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            string textInput = Console.ReadLine();
            Console.WriteLine(ParseTagsToUpper(textInput));
        }

        static string ParseTagsToUpper(string text)
        {
            while (text.IndexOf("<upcase>") > -1 && text.IndexOf("</upcase>") > -1)
            {
                int startIndex = text.IndexOf("<upcase>");
                int endIndex = text.IndexOf("</upcase>");

                string subText = text.Substring(startIndex, endIndex - startIndex);

                string result = text.Replace(subText, subText.ToUpper());
                result = result.Remove(endIndex,9);
                text = result.Remove(startIndex, 8);

            }
            return text;
        }
       


    }
}
