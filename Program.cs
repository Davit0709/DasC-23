using System;

class Program
{
    static void Main()
    {
        int[,] spiralArray = new int[4, 4];
        int value = 1;
        int x = 0, y = 0;
        int n = 4;

        while (value <= n * n)
        {

            for (int i = y; i < n - y; i++)
            {
                spiralArray[x, i] = value++;
            }


            for (int i = x + 1; i < n - x; i++)
            {
                spiralArray[i, n - y - 1] = value++;
            }

            if (n - x - 1 == x || n - y - 1 == y)
            {
                break;
            }

            for (int i = n - y - 2; i >= y; i--)
            {
                spiralArray[n - x - 1, i] = value++;
            }

            for (int i = n - x - 2; i > x; i--)
            {
                spiralArray[i, y] = value++;
            }

            x++;
            y++;
        }


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", spiralArray[i, j]);
            }
            Console.WriteLine();
        }
    }
}
