using System;


class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Enter a Number : ");
        int number = Convert.ToInt16(Console.ReadLine());
        double SqrtNumber = Math.Sqrt(number);
        Console.Beep();
        Console.WriteLine("Square root of {0} is : {1}", number, SqrtNumber);
    }
}


