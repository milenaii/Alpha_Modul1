using System;

namespace Adding_polynomials
{
    class AddPolin
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstPol = Console.ReadLine().Split(' ');
            string[] secPol = Console.ReadLine().Split(' ');

            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                res[i] = int.Parse(firstPol[i]) + int.Parse(secPol[i]);
                if (i == n - 1)
                {
                    Console.WriteLine(res[i]);
                }
                else
                {
                    Console.Write(res[i] + " ");
                }
            }


        }
    }
}
