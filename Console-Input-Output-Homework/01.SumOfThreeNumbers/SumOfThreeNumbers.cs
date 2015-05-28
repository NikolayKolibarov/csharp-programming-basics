using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers: ");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("Sum: " + (firstNum + secondNum + thirdNum));
        
    }
}

