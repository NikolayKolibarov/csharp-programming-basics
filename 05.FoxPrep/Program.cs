using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 2 * n + 3;

        int left = 1;
        int right = width - 2;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (col == left) {
                    Console.Write("\\");
                }
                else if (col == right)
                {
                    Console.Write("/");
                }
                else if (col > left && col < right)
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write("*");
                }
            }

            left++;
            right--;
            Console.WriteLine();
        }

        int middleHeight = n / 3;
        int offset = n / 2 + 1;
        left = offset;
        right = width - 1 - offset;

        for (int row = 0; row < middleHeight; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (col == 0 || col == width - 1)
                {
                    Console.Write("|");
                }
                else if (col == left)
                {
                    Console.Write("\\");
                }
                else if (col == right)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write("*");
                }
            }

            left++;
            right--;
            Console.WriteLine();
        }

        left = 1;
        right = width - 2;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (col == left)
                {
                    Console.Write("\\");
                }
                else if (col == right)
                {
                    Console.Write("/");
                }
                else if (col > left && col < right)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }

            left++;
            right--;
            Console.WriteLine();
        }
    }
}
