using System;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
            //Create and write file
            string fileName = "fileForReadingOddLines.txt";
            StreamWriter createrAndWriteFile = new StreamWriter(fileName);

            using (createrAndWriteFile)
            {
                for (int i = 1; i < 17; i++)
                {
                    createrAndWriteFile.WriteLine(i);
                }
            }
            //Reading the file and print odd lines

            StreamReader readOddLines = new StreamReader(fileName);
            using (readOddLines)
            {
                int lineNum = 1;
                string line = readOddLines.ReadLine();  // like do...while
                while (line != null)
                {
                    if (lineNum % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineNum++;
                    line = readOddLines.ReadLine();
                }
            }

            //StreamReader readOddLines = new StreamReader(fileName);
            //using (readOddLines)
            //{
            //    string line = readOddLines.ReadLine();  

            //    for (int i = 1; i <= fileName.Length; i++)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            Console.WriteLine(line);
            //        }
            //            line = readOddLines.ReadLine();
            //    }
            //}
        }
    }
}
