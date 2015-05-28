using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position:");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int result = mask & number;
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("#{0} bit is {1}", position, result >> position);
    }
}

