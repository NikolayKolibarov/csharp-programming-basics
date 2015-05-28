using System;

class CalculateGCD
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("Enter number a: ");
        while (!int.TryParse(Console.ReadLine(),out a))
        {
            Console.WriteLine("You must enter an integer: ");
        }

        Console.WriteLine("Enter number b: ");
        while (!int.TryParse(Console.ReadLine(),out b))
        {
            Console.WriteLine("You must enter an integer: ");
        }

        int remainder = a % b;
        while (remainder !=0)
        {
            a = b;
            b = remainder;
            remainder = a % b;
        }
        Console.WriteLine();
        Console.Beep();
        Console.WriteLine(Math.Abs(b));
    }
}

