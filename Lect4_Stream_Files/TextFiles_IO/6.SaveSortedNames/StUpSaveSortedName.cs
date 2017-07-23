using System;
using System.IO;
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
namespace _6.SaveSortedNames
{
    class StUpSaveSortedName
    {
        static void Main()
        {
            string fileName = "FileNames.txt";
            StreamWriter writer = new StreamWriter(fileName);

            CreateFile(writer);
            SortNames(fileName);

            //StreamWriter writeRes = new StreamWriter("fileRes.txt");
            //PrintFileRes(writeRes);
        }

        //private static void PrintFileRes(StreamWriter writeRes)
        //{
        //    using (writeRes)
        //    {
        //        writeRes.Write()
        //    }
        //}

        private static void CreateFile(StreamWriter writer)
        {
            using (writer)
            {
                writer.Write("Ivan Peter Maria George");
            }
        }

        private static void SortNames(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                string[] input = reader.ReadToEnd().Split(' ');
                for (int i = 0; i < input.Length - 1; i++)
                {
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (string.Compare(input[i], input[i + 1]) == -1)
                        {
                            string temp = "";
                            temp = input[i];
                            input[i] = input[j];
                            input[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < input.Length; i++)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}
