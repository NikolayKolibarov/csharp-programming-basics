using System;

class BitwiseExtraction
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int result = mask & number;
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("#3 bit is {0}", result >> 3);
    }
}

