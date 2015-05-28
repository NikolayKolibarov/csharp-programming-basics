using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter a value for X:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for Y:");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.Beep();
        bool isInside = (x * x) + (y * y) < 2 * 2;
        Console.WriteLine(isInside);
    }
}

