using System;

class NumbersFromOneToN
{
    static void Main()
    {
        int number;
        Console.WriteLine("Enter integer: ");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("The number must be an integer: ");
        }
        Console.WriteLine("");
        Console.Beep();
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

