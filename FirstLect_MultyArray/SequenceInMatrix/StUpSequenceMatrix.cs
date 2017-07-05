using System;

namespace SequenceInMatrix
{
    class StUpSequenceMatrix
    {
        static void Main()
        {
            //reading input
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[,] matrix = new int[n, m];

            int counter = 1;

            int maxCount = 1;

            //int col = 0;
            //int row = 0;

            //Reading the matrix
            for (int r = 0; r < n; r++)
            {
                input = Console.ReadLine().Split(' ');
                for (int c = 0; c < m; c++)
                {
                    matrix[r, c] = int.Parse(input[c]);
                }
            }
            //Find max sequence
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    while (col < m - 1 && matrix[row, col] == matrix[row, col + 1])
                    {
                        col++;
                        counter++;
                    }

                    if (maxCount < counter)
                    {
                        maxCount = counter;
                    }

                    counter = 1;

                    while (row < n - 1 && matrix[row, col] == matrix[row + 1, col])
                    {
                        row++;
                        counter++;
                    }

                    if (maxCount < counter)
                    {
                        maxCount = counter;
                    }

                    counter = 1;

                    while (row < n - 1 && col < m - 1 && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        row++;
                        col++;
                        counter++;
                    }

                    if (maxCount < counter)
                    {
                        maxCount = counter;
                    }

                    counter = 1;

                    while (col > 0 && row < n - 1 && col < m + 1 && matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        row++;
                        col--;
                        counter++;
                    }

                    if (maxCount < counter)
                    {
                        maxCount = counter;
                    }

                    counter = 1;
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}
