using System;

namespace MaxSum
{
    class StUpMaxSum
    {
        static void Main()
        {
            //Reading the input
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[,] matr = FillMatrix(n, m, input);

            int max = FindMaxSum(n, m, matr);
            
            Console.WriteLine(max);

        }

        static int[,] FillMatrix(int n, int m, string[] input)
        {
            int[,] matrix = new int[n, m];

            for (int r = 0; r < n; r++)
            {
                input = Console.ReadLine().Split();

                for (int c = 0; c < m; c++)
                {
                    matrix[r, c] = int.Parse(input[c]);
                }
            }
            return matrix;
        }

        static int FindMaxSum(int n, int m, int [,] matr)
        {
            int maxSum = int.MinValue;
            int sum = int.MinValue;

            for (int r = 0; r < n - 2; r++)
            {
                for (int c = 0; c < m - 2; c++)
                {
                    sum = matr[r, c] + matr[r + 1, c] + matr[r + 2, c] + matr[r, c + 1] + matr[r + 1, c + 1] + matr[r + 2, c + 1] + matr[r, c + 2] + matr[r + 1, c + 2] + matr[r + 2, c + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }
    }
}
