using System;
using System.IO;

namespace TextFiles_IO
{
    class WriteFile
    {
        static void Main()
        {
            string fileName = @"../../../myFirstFile.txt";

            StreamWriter writeFile = new StreamWriter(fileName);

            using (writeFile)
            {
                for (int i = 0; i <= 10; i++)
                {
                    writeFile.Write(i + " ");
                }
            }
            Console.WriteLine("The file is written!");
        }
    }
}
