using System;

class PointInsideCircleAndOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter value for X:");
        double x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for Y:");
        double y = int.Parse(Console.ReadLine());
        bool isInsideCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
        bool isOutsideRectangle = x > 1 || x < 6 && y > -1 || y < 2;
        Console.WriteLine("");
        Console.Beep();
        if (x == 0 || y == 0)
        {
            Console.WriteLine("Not inside circle and outside rectangle.");
        }
        else if (isInsideCircle == true && isOutsideRectangle == true)
        {
            Console.WriteLine("Is inside circle and outside rectangle.");
        }
        else
        {
            Console.WriteLine("Not inside circle and outside rectangle.");
        }
    }
}

