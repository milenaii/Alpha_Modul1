using System;
using System.IO;

//Read the file from task WriteFile
namespace ReadFile
{
    class Program
    {
        static void Main()
        {
            string fileName = @"../../../myFirstFile.txt";
            StreamReader readFile = new StreamReader(fileName);

            using (readFile)
            {
                readFile.ReadToEnd();
            }
            Console.WriteLine();


            //2  way with print on the console
            //string contain = "";
            //using (readFile)
            //{
            //    contain = readFile.ReadToEnd();
            //}
            //Console.WriteLine(contain);
        }
    }
}
