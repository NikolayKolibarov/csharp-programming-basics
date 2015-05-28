using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle height:");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle width:");
        double width = double.Parse(Console.ReadLine());
        double perimeter = 2 * (height + width);
        double area = height * width;
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("Perimeter: {0}", perimeter);
        Console.WriteLine("Area: {0}", area);
    }
}

