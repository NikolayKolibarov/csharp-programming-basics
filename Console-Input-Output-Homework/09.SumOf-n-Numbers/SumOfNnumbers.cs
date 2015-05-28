using System;

class SumOfNnumbers
{
    static void Main()
    {
        int count;
        Console.WriteLine("Enter number count: ");
        while (!int.TryParse(Console.ReadLine(), out count))
        {
            Console.WriteLine("The number count must be an integer: ");
        }
        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter number: ");
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("Sum: {0}", sum);
    }
}

