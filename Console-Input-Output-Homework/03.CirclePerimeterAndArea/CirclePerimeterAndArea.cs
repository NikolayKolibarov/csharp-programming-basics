using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter circle radius: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("Circle perimeter: {0:0.00} \nCircle area: {1:0.00}",perimeter ,area);
    }
}

