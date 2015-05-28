using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        uint checker;
        Console.WriteLine("Enter a number to check if it can be devided by 7 and 5 :");
        while (!uint.TryParse(Console.ReadLine(), out checker))
        {
            Console.WriteLine("The number must be an interger:");
        }
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("{0} - {1}", checker, (((checker % 7 == 0) && (checker % 5 == 0)) ? "It can be devided by 7 and 5" : "It can't be devided by 7 and 5"));
    }
}