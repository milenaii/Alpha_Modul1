using System;
using System.IO;

namespace LineNumbers
{
    class StUpLineNumbers
    {
        static void Main()
        {
            StreamReader readFile = new StreamReader("fileLineNumbers.txt");
            using (readFile)
            {
                int lineNum = 0;
                string line = readFile.ReadLine();
                while (line != null)
                {
                    lineNum++;
                    Console.WriteLine("{0} {1}",lineNum, line);
                    line = readFile.ReadLine();
                }
            }

           // StreamWriter writeFile = new StreamWriter("ResultFile.txt");


           


        }
    }
}
