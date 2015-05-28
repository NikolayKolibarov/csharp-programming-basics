using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumbersNotDivisibleBy3and7
{
    static void Main()
    {
        int number;
        Console.WriteLine("Enter a positive integer: ");
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("You must enter a positive integer");
        }

        Console.WriteLine("");
        Console.Beep();

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

