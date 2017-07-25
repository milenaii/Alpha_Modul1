using System;

namespace MovingBackAndForward
{
    class Moving
    {
        static void Main()
        {
            int startP = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(',');
            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int sumF = 0;
            int sumB = 0;
            int count = 0;

            string moves = Console.ReadLine();

            while (moves != "exit")
            {
                string[] move = moves.Split(' ');
                int step = int.Parse(move[0]);
                int size = int.Parse(move[2]);

                string dir = move[1];
                if (dir == "forward")
                {
                    while (count < step)
                    {
                        startP = (startP + size) % arr.Length;

                        sumF += arr[startP];
                        count++;
                    }
                    count = 0;
                }
                if (dir == "backwards")
                {
                    while (count < step)
                    {
                        //Find mirror index
                        int mirStartP = arr.Length - startP - 1;

                        //how he can go forward
                        mirStartP = (mirStartP + size) % arr.Length;

                        //Find mirror on your mirror - searched index
                        startP = arr.Length - mirStartP - 1;

                        sumB += arr[startP];
                        count++;
                    }
                    count = 0;
                }
                moves = Console.ReadLine();
            }
            Console.WriteLine("Forward: {0}", sumF);
            Console.WriteLine("Backwards: {0}", sumB);
        }
    }
}
