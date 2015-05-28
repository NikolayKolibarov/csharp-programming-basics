using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter a number n: ");
        while (!int.TryParse(Console.ReadLine(),out n))
        {
            Console.WriteLine("You must enter an integer: ");
        }

        BigInteger numerator = 1;
        BigInteger denumerator = 1;
        BigInteger result = 1;

        Console.WriteLine();
        Console.Beep();
        if  (1 < n && n < 100) 
            {
                for (int i = 2; i <= n ; i++)
                {
                    numerator *= n + i;
                    denumerator *= i;
                    Console.WriteLine(numerator);

                }

                result = numerator / denumerator;
                Console.WriteLine(result);
            }

        else
        {
            Console.WriteLine("n must be more than 1 and less than 100.");
        }

    }
}

