using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a, b, c, biggestNum;
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
        Console.WriteLine("");
        Console.Beep();
        if (a > b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine("{0} {1} {2}",a ,b ,c);
            }

            else
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
        }

        else if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine("{0} {1} {2}",b ,a ,c);
            }

            else
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }

        else if (c > b && c > a)
        {
            if (a > b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }

            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }

        else
        {
            Console.WriteLine("{0} {1} {2}",a ,b ,c);
        }
    }
}

