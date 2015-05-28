using System;
using System.Numerics;


class DevideFactorialByFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter an integer for factorial n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer for factorial k: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        if (!(1 < k && k < n && n < 100))
        {
            Console.WriteLine("k must not be less than 1, k must be less than n and n must be less than 100.");
        }
        else
        {
            for (int i = k + 1; i <= n; i++)
            {
                result *= (BigInteger)i;
            }
            Console.WriteLine("");
            Console.Beep();
            Console.WriteLine(result);
       
        }
        
    }
}

