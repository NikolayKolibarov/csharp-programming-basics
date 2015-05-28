using System;

class FormattingNumbers
{
    static void Main()
    {
        int a;
        Console.WriteLine("Enter integer a: ");
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 499) Console.WriteLine("The integer must be less than 500 and greater than 0: ");
        Console.WriteLine("Enter real number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter real number c: ");
        double c = double.Parse(Console.ReadLine());
        bool check = Convert.ToString(c).IndexOf(".") > 0;
        Console.WriteLine("");
        Console.Beep();
        Console.Write("|{0}|{1}|{2,10:0.00}|", (a.ToString("X").PadRight(10,' ')) ,(Convert.ToString(a, 2).PadLeft(10,'0')) ,b);
        Console.WriteLine(check ? "{0,-10:0.000}|" : "{0,-10}|",c);

    }
}

