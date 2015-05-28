using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a, b, c, biggestnum;
        Console.WriteLine("Enter number a: ");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("You must enter a number: ");
        }

        Console.WriteLine("Enter number b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("You must enter a number: ");
        }

        Console.WriteLine("Enter number c: ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("You must enter a number: ");
        }

        if (a > b)
        {
            if (a > c)
            {
                biggestnum = a;
            }

            else
            {
                biggestnum = c;
            }
        }

        else
        {
            if (b > c)
            {
                biggestnum = b;
            }

            else
            {
                biggestnum = c;
            }
        }
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("Biggest: " + biggestnum);
    }
}



