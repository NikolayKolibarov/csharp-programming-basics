using System;

class FormulaCalculation
{
    static void Main()
    {
        Console.WriteLine("Enter an integer for n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter an integer for k: ");
        int k = int.Parse(Console.ReadLine());
        int result;
        int result1 = 1;
        int result2 = 1;
        int count = 1;
        int nkSub = n - k;

        if (!(1 < k && k < n && n < 100))
        {
            Console.WriteLine("k must not be less than 1, k must be less than n and n must be less than 100.");
        }

        else
        {
            for (int i = n - k + 1; i <= n; i++)
            {
                result1 *= i;
                if (count <= k)
                {
                    result2 *= count;
                    count++;
                }
            }
            result = result1 / result2;
            Console.WriteLine();
            Console.Beep();
            Console.WriteLine(result);
        }

       
    }
}

