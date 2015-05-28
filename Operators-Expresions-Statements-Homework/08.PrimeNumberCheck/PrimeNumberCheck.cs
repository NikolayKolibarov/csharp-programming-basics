using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        if (number == 1)
        {
            Console.WriteLine("This is not a prime number");
        }
        else
        {
            int checker = 0;
            for (int i = 1; i < 100; i++)
            {
                if (number % i == 0)
                {
                    checker++;
                }
            }
            bool isPrime = true;
            if (checker > 2)
            {
                isPrime = false;
            }
            Console.WriteLine("");
            Console.Beep();
            Console.WriteLine("This is a prime number: {0}", isPrime);
        }
    }
}

