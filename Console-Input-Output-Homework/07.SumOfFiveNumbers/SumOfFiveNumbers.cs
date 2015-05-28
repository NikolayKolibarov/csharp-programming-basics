using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter numbers: ");
        string[] numbers = Console.ReadLine().Split(' ');
        double a = double.Parse(numbers[0]);
        double b = double.Parse(numbers[1]);
        double c = double.Parse(numbers[2]);
        double d = double.Parse(numbers[3]);
        double e = double.Parse(numbers[4]);
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("Sum: " + (a + b + c + d + e));
    }
}

