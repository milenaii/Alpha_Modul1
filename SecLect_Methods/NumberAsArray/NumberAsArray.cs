using System;
//not finished
namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            string[] firstNum = Console.ReadLine().Split(' ');
            int[] first = new int[n];
            for (int i = 0; i < firstNum.Length - 1; i++)
            {
                first[i] = int.Parse(firstNum[i]);
            }

            string[] secNum = Console.ReadLine().Split();
            int[] second = new int[m];
            for (int i = 0; i < secNum.Length - 1; i++)
            {
                second[i] = int.Parse(secNum[i]);
            }

            //1
            if (first.Length < second.Length)
            {
                int[] res = new int[second.Length];

                for (int i = 0; i < second.Length; i++)
                {
                    if (i <= first.Length - 1)
                    {
                        res[i] = (first[i] + second[i]) % 10;
                        res[i + 1] += (first[i] + second[i]) / 10;
                    }
                    else if (i >= first.Length && i <= second.Length - 1)
                    {
                        res[i] = second[i];
                    }
                   // res[i] = first[i] + second[i];
                }
                for (int i = 0; i < res.Length; i++)
                {
                    if (i == res.Length - 1)
                    {
                        Console.WriteLine(res[i]);
                    }
                    Console.WriteLine(res[i] + " ");
                }

            }
            //2
            else if (first.Length > second.Length)
            {
                int[] res = new int[first.Length];

                for (int i = 0; i < second.Length; i++)
                {
                    if (i <= second.Length - 1)
                    {
                        res[i] = (first[i] + second[i]) % 10;
                        res[i + 1] += (first[i] + second[i]) / 10;
                    }
                    else if (i >= second.Length && i <= first.Length - 1)
                    {
                        res[i] = first[i];
                    }
                    res[i] = first[i] + second[i];

                }
                for (int i = 0; i < res.Length; i++)
                {
                    if (i == res.Length - 1)
                    {
                        Console.WriteLine(res[i]);

                    }
                    Console.WriteLine(res[i] + " ");
                }
            }
            else if (first.Length == second.Length)
            {
                int[] res = new int[second.Length];

                for (int i = 0; i < second.Length; i++)
                {
                    if (i == second.Length - 1)
                    {
                        res[i] = (first[i] + second[i]) % 10;
                    }
                    else if (i != second.Length - 1)
                    {
                        res[i] = (first[i] + second[i]) % 10;
                        res[i + 1] = (first[i] + second[i]) / 10;
                    }
                }
                for (int i = 0; i < res.Length; i++)
                {
                    if (i == res.Length - 1)
                    {
                        Console.WriteLine(res[i]);

                    }
                    Console.WriteLine(res[i] + " ");
                }


            }

        }
    }
}
