using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter real number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter real number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter real number c: ");
        double c = double.Parse(Console.ReadLine());
        double discriminant = Math.Pow(b, 2) - 4 * a * c;
        double x1;
        double x2;
        Console.WriteLine("");
        Console.Beep();
        if (discriminant > 0)
        {
            x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("X1: {0} \nX2: {1}",x1 ,x2);
        }
        else if (discriminant == 0)
        {
            x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("X1=X2: {0}", x1);
        }
        else 
        {
            Console.WriteLine("No real roots.");
        }
    }
}

