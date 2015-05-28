using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("The greater number is: " + Math.Max(a,b));
    }
}

