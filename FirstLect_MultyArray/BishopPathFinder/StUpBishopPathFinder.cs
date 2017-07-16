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

            int[,] mat = new int[n, m];

            FillTheMatrix(n, m, mat);

            bool[,] bo = new bool[n, m];  //false

            int numMoves = int.Parse(Console.ReadLine());

            //initial conditions
            int sum = 0;
            int c = 0;
            int r = n - 1;

            for (int i = 1; i <= numMoves; i++)
            {
                int count = 0;
                string[] inp = Console.ReadLine().Split(' ');
                string d = inp[0];
                int k = int.Parse(inp[1]);

                if (d == "RU" || d == "UR")
                {
                    if (n >= m && k >= n)
                    {
                        k = n;
                    }
                    else if (m > n && k >= m)
                    {
                        k = m;
                    }

                    //sum = SumsUpRight(n, m, mat, bo, k, sum, r, c);
                    while (r >= 0 || c <= m - 1)
                    {
                        if (bo[r, c])   // bool is true
                        {
                            r--;
                            c++;
                            count++;
                        }
                        else            //bool is false
                        {
                            bo[r, c] = true;
                            sum += mat[r--, c++];
                            count++;
                        }
                        if (r == -1 || c == m)
                        {
                            c--;
                            r++;
                            break;
                        }
                        if (count == k)
                        {
                            r++;
                            c--;
                            break;
                        }
                    }
                }
                //Console.WriteLine(sum);

                else if (d == "RD" || d == "DR")
                {
                    if (n >= m && k >= n)
                    {
                        k = n;
                    }
                    else if (m > n && k >= m)
                    {
                        k = m;
                    }
                    //sum = SumsDownRight(n, m, mat, bo, k, sum, r, c);
                    while (r <= n - 1 || c <= m - 1)
                    {
                        if (bo[r, c])
                        {
                            r++;
                            c++;
                            count++;
                        }
                        else
                        {
                            bo[r, c] = true;
                            sum += mat[r++, c++];
                            count++;
                        }
                        if (c == m || r == n)
                        {
                            c--;
                            r--;
                            break;
                        }
                        if (count == k)
                        {
                            c--;
                            r--;
                            break;
                        }
                    }
                }
                else if (d == "LD" || d == "DL")
                {
                    if (n >= m && k >= n)
                    {
                        k = n;
                    }
                    else if (m > n && k >= m)
                    {
                        k = m;
                    }
                    //sum = SumsDownRight(n, m, mat, bo, k, sum, r, c);
                    while (r <= n - 1 || c >= 0)
                    {
                        if (bo[r, c])
                        {
                            r++;
                            c--;
                            count++;
                        }
                        else
                        {
                            bo[r, c] = true;
                            sum += mat[r++, c--];
                            count++;
                        }
                        if (c == -1 || r == n)
                        {
                            c++;
                            r--;
                            break;
                        }
                        if (count == k)
                        {
                            c++;
                            r--;
                            break;
                        }
                    }
                }
                else if (d == "LU" || d == "UL")
                {
                    if (n >= m && k >= n)
                    {
                        k = n;
                    }
                    else if (m > n && k >= m)
                    {
                        k = m;
                    }
                    //sum = SumsDownRight(n, m, mat, bo, k, sum, r, c);
                    while (r >= 0 || c >= 0)
                    {
                        if (bo[r, c])
                        {
                            r--;
                            c--;
                            count++;
                        }
                        else
                        {
                            bo[r, c] = true;
                            sum += mat[r--, c--];
                            count++;
                        }
                        if (r == -1 || c == m || r == n || c == -1)
                        {
                            c++;
                            r++;
                            break;
                        }
                        if (count == k)
                        {
                            c++;
                            r++;
                            break;
                        }
                    }
                }
            }

            //PrintTheMatrixResult(n, m, mat);
            // PrintTheMatrixBool(n, m, bo);
            Console.WriteLine(sum);
        }

        //private static int SumsDownRight(int n, int m, int[,] mat, bool[,] bo, int k, int sum, int r, int c)
        //{
        //    while (r <= n - 1 || c == 0)
        //    {
        //        if (bo[r, c])
        //        {
        //            r++;
        //            c--;
        //        }
        //        else
        //        {
        //            bo[r, c] = true;
        //            sum += mat[r++, c--];
        //        }
        //        if (c == -1 || r == m)
        //        {
        //            c++;
        //            r--;
        //            break; ;
        //        }
        //        //if (r == m)
        //        //{
        //        //    c++;
        //        //    r--;
        //        //    break;
        //        //}
        //    }
        //    //Console.WriteLine(sum);
        //    return sum;
        //}

        //private static int SumsUpRight(int n, int m, int[,] mat, bool[,] bo, int k, int sum, int r, int c)
        //{
        //    while (r == 0 || c <= m - 1)
        //    {
        //        if (bo[r, c])
        //        {
        //            r--;
        //            c++;
        //        }
        //        else
        //        {
        //            bo[r, c] = true;
        //            sum += mat[r--, c++];
        //        }
        //        if (r == -1 || c == m)
        //        {
        //            c--;
        //            r++;
        //            break; ;
        //        }
        //        //if (c == m)
        //        //{
        //        //    c--;
        //        //    r++;
        //        //    break;
        //        //}
        //    }
        //    //Console.WriteLine(sum);

        //    return sum;
        //}
        private static void FillTheMatrix(int n, int m, int[,] mat)
        {
            int count = 0;
            for (int c = 0; c < m; c++)
            {
                count = c * 3;
                for (int r = n - 1; r >= 0; r--)
                {
                    mat[r, c] += count;
                    count += 3;
                }
            }
        }

        private static void PrintTheMatrixResult(int n, int m, int[,] mat)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    if (c == m - 1)
                    {
                        Console.Write(mat[r, c]);
                    }
                    else
                    {
                        Console.Write(mat[r, c] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void PrintTheMatrixBool(int n, int m, bool[,] bo)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    if (c == m - 1)
                    {
                        Console.Write(bo[r, c]);
                    }
                    else
                    {
                        Console.Write(bo[r, c] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
