using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position:");
        int position = int.Parse(Console.ReadLine());
        bool checkNumber = (number & (1 << position)) != 0;
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("Does the #{0} bit equal 1: {1}",position, checkNumber);

    }
}
