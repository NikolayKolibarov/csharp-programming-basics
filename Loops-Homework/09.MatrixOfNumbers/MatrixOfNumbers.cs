 using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter an integer number:");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 20)
        {
            Console.WriteLine("You must enter a positive intger between 1 and 20: ");
        }

        Console.WriteLine();
        Console.Beep();
        for (int row = 1; row <= n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(row + col + " ");
            }
            Console.WriteLine();
        }

    }
}

