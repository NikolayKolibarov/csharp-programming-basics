using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int count, minNum, maxNum;
        Console.WriteLine("Enter number count: ");
        while (!int.TryParse(Console.ReadLine(),out count) || count < 0)
        {
            Console.WriteLine("You must enter a positive number count: ");
        }

        Console.WriteLine("Enter minimal number: ");
        while (!int.TryParse(Console.ReadLine(),out minNum))
        {
            Console.WriteLine("You must enter a number: ");
        }

        Console.WriteLine("Enter maximal number: ");
        while (!int.TryParse(Console.ReadLine(),out maxNum))
        {
            Console.WriteLine("You must enter a number: ");
        }

        Console.WriteLine();
        Console.Beep();
        if (minNum <= maxNum)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0} ", randomNumber.Next(minNum, maxNum + 1));
            }
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Min number can't be bigger than the Max number.");
        }
    }
}

