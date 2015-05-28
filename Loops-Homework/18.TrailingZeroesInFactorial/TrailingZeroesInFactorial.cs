using System;
using System.Numerics;

class TrailingZeroesInFactorial
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter factorial n: ");
        while (!int.TryParse(Console.ReadLine(),out n))
        {
            Console.WriteLine("You must enter an integer: ");
        }

        BigInteger factorial = 1;
        int zeroTrail = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        while (factorial % 10 == 0)
        {
            zeroTrail++;
            factorial /= 10;
        }
        Console.WriteLine();
        Console.Beep();
        Console.WriteLine("Trailing zeroes of factorial: {0}", zeroTrail);
        
    }
}

