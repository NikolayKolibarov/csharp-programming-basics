using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter an integer to check if it is odd or even:");
        int number = int.Parse(Console.ReadLine());
        int checker = number % 2;
        string result = (checker == 0 ? "Even" : "Odd");
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine(result);
    }
}

