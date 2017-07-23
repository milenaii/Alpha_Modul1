using System;
using System.IO;
//Write a program that reads a text file containing a square matrix of numbers. Find an area of size `2 x 2` in the matrix, with a maximal sum of its elements.
//- The first line in the input file contains the size of matrix `N`.
//- Each of the next `N` lines contain `N` numbers separated by space.
//- The output should be a single number in a separate text file.



namespace _5.MaximalAreaSum
{
    class StUuMaxSum
    {
        static void Main()
        {
            //create File

            //StreamWriter writer = new StreamWriter("fileMaxSum.txt");
            //using (writer)
            //{
            //    writer.WriteLine("4");
            //    writer.WriteLine("2 3 3 4");
            //    writer.WriteLine("0 2 3 4");
            //    writer.WriteLine("3 7 1 2");
            //    writer.WriteLine("4 3 3 2");
            //}

            StreamReader reader = new StreamReader("fileMaxSum.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int n = int.Parse(line);
                int[,] matrix = new int[n, n];

                for (int row = 0; row < n; row++)
                {
                    line = reader.ReadLine();
                    string[] input = line.Split();
                    for (int col = 0; col < n; col++)
                    {
                        matrix[row, col] = int.Parse(input[col]);
                        //Console.WriteLine(matrix[row, col]);
                    }
                }
                int sum = int.MinValue;
                int maxSum = int.MinValue;

                for (int row = 0; row < n - 1; row++)
                {
                    for (int col = 0; col < n - 1; col++)
                    {
                        sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                        if (sum > maxSum)
                        {
                            maxSum = sum;
                        }
                    }
                }

                StreamWriter write = new StreamWriter("fileResMaxSum.txt");
                using (write)
                {
                    write.WriteLine(maxSum);
                }
               // Console.WriteLine(maxSum);
            }
        }
    }
}