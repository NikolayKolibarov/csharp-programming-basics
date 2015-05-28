using System;

class IsTheThirdDigitSeven
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int hundreds = number / 100;
        int remainder = hundreds % 10;
        bool isSeven = remainder == 7;
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("Third digit of number is 7: {0}", isSeven);
    }
}

