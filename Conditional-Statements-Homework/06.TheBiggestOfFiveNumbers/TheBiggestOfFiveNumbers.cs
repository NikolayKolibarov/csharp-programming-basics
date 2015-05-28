using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double a, b, c, d, e, biggestNum;
        Console.WriteLine("Enter real number a: ");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("You must enter a number: ");
        }

        Console.WriteLine("Enter real number b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("You must enter a number: ");
        }

        Console.WriteLine("Enter real number c: ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("You must enter a number: ");
        }

          Console.WriteLine("Enter real number d: ");
        while (!double.TryParse(Console.ReadLine(), out d))
        {
            Console.WriteLine("You must enter a number: ");
        }

          Console.WriteLine("Enter real number e: ");
        while (!double.TryParse(Console.ReadLine(), out e))
        {
            Console.WriteLine("You must enter a number: ");
        }
        Console.WriteLine("");
        Console.Beep();

        if (a > b && a > c && a > d && a > e)
        {
            biggestNum = a;
            Console.WriteLine("Biggest: " + biggestNum);
        }

        else if (b > a && b > c && b > d && b > e)
        {
            biggestNum = b;
            Console.WriteLine("Biggest: " + biggestNum);
        }

        else if (c > a && c > b && c > e && c > d)
        {
            biggestNum = c;
            Console.WriteLine("Biggest: " + biggestNum);
        }

        else if (d > a && d > b && d > c && d > e)
        {
            biggestNum = d;
            Console.WriteLine("Biggest: " + biggestNum);
        }

        else if (e > a && e > b && e > c && e > d)
        {
            biggestNum = e;
            Console.WriteLine("Biggest: " + biggestNum);
        }
    }
    
}
    
    



