using System;

namespace Prooba
{
    class Proba
    {
        static void Main()
        {

            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[,] matrix = new int[n, m];
            //Read
            for (int r = 0; r < n; r++)
            {
                string[] mat = Console.ReadLine().Split(' ');

                for (int c = 0; c < m; c++)
                {
                    matrix[r, c] = int.Parse(mat[c]);
                }
            }
            int count = 1;
            int maxCount = 1;


            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m - 1; c++)
                {
                    while (c < m - 1)
                    {
                        if (matrix[r, c] == matrix[r, c + 1])
                        {
                            count++;
                            c++;
                            if (count > maxCount)
                            {
                                maxCount = count;
                            }
                            if (c == m - 1)
                            {
                                break;
                            }
                        }
                        else
                        {
                            count = 1;
                            break;
                        }
                    }
                    while (r < n - 1)
                    {
                        if (matrix[r, c] == matrix[r + 1, c])
                        {
                            count++;
                            r++;
                            if (count > maxCount)
                            {
                                maxCount = count;
                            }
                            if (r == n - 1)
                            {
                                break;
                            }
                        }
                        else
                        {
                            count = 1;
                            break;
                        }
                    }
                    while (r < n - 1 && c < m - 1)
                    {
                        if (matrix[r, c] == matrix[r + 1, c + 1])
                        {
                            count++;
                            r++;
                            c++;
                            if (count > maxCount)
                            {
                                maxCount = count;
                            }
                            if (r == n - 1 || c == m - 1)
                            {
                                break;
                            }
                        }
                        else
                        {
                            count = 1;
                            break;
                        }
                    }
                }
            }
            for (int r = 0; r < n; r++)
            {
                for (int c = m - 1; c >= 0 ; c--)
                {
                    while (c > 0 && r < n - 1)
                    {
                        if (matrix[r, c] == matrix[r + 1, c - 1])
                        {
                            count++;
                            r++;
                            c--;
                            if (count > maxCount)
                            {
                                maxCount = count;
                            }
                            if (r == n - 1 || c == 0)
                            {
                                break;
                            }
                        }
                        else
                        {
                            count = 1;
                            break;
                        }
                    }

                }
            }
            Console.WriteLine(maxCount);
            


            //Print
            //for (int r = 0; r < n; r++)
            //{
            //    for (int c = 0; c < n; c++)
            //    {
            //        if (c == n - 1)
            //        {
            //            Console.WriteLine(matrix[r, c]);
            //        }
            //        else
            //        {
            //            Console.Write(matrix[r, c] + " ");
            //        }
            //    }
            //}
        }
    }
}