using System;

namespace FillTheMatrixDD
{
    class FillTheMatrixD
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] m = new int[n, n];
            int count = 1;

            //Fill the matrix "d"
            int r = 0;
            int c = 0;
            int moveR = 1;
            int moveC = 0;

            while (count <= n * n)
            {
                if (r == n || c == n || r == -1 || c == -1 || m[r, c] != 0)
                {
                    if (moveR == 1)
                    {
                        r--;
                        moveR = 0;
                        moveC = 1;
                        r += moveR;
                        c += moveC;
                    }
                    else if (moveC == 1)
                    {
                        c--;
                        moveR = -1;
                        moveC = 0;
                        r += moveR;
                        c += moveC;
                    }
                    else if (moveR == -1)
                    {
                        r++;
                        moveR = 0;
                        moveC = -1;
                        r += moveR;
                        c += moveC;
                    }
                    else if (moveC == -1)
                    {
                        c++;
                        moveR = 1;
                        moveC = 0;
                        r += moveR;
                        c += moveC;
                    }

                }
                m[r, c] = count++;
                r += moveR;
                c += moveC;
            }
            //Print
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == n - 1)
                    {
                        Console.WriteLine(m[row, col]);
                    }
                    else
                    {
                        Console.Write(m[row, col] + " ");
                    }
                }
            }
        }
    }
}
