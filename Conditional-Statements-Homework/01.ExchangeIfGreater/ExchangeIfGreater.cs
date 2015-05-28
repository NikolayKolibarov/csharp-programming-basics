using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double firstNumber, secondNumber;
        Console.WriteLine("Enter real number a: ");
        while (!double.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.WriteLine("You must enter a number: ");
        }
        Console.WriteLine("Enter real number b: ");
        while (!double.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.WriteLine("You must enter a number: ");
        }
        Console.Beep();
        if (firstNumber > secondNumber)
        {
            Console.WriteLine("\n{0} {1}",secondNumber ,firstNumber);   
        }
        else
        {
            Console.WriteLine("\n{0} {1}",firstNumber ,secondNumber);
        }
    }
}

