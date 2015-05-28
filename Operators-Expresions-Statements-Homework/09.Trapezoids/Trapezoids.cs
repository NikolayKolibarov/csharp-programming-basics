using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter value for side a:");
        int sideA = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for side b");
        int sideB = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for height h:");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.Beep();
        int area = (sideA + sideB) / 2 * height;
        Console.WriteLine("The area of this trapezoid is: {0}",area);
    }
}

