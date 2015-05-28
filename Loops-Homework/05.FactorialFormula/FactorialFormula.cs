using System;

class FactorialFormula
{
    static void Main()
    {
        int n, x;
        Console.WriteLine("Please enter a number for n!: ");
        while (!int.TryParse(Console.ReadLine(),out n))
        {
            Console.WriteLine("You must enter an integer: ");
        }

        Console.WriteLine("Please enter a number for x: ");
        while (!int.TryParse(Console.ReadLine(),out x))
        {
            Console.WriteLine("You must enter an integer: ");
        }

        double factN = 1;
        double multiX = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            multiX *= x;
            result += (factN / multiX);
        }
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("{0,0:0.00000}",result);
    }
}

