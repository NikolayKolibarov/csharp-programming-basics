using System;

class MultiplicationSign
{
    static void Main()
    {
        double firstNumber, secondNumber, thirdNumber;
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

        Console.WriteLine("Enter real number c: ");
        while (!double.TryParse(Console.ReadLine(), out thirdNumber))
        {
            Console.WriteLine("You must enter a number: ");
        }
        
        Console.Beep();
        if (firstNumber * secondNumber * thirdNumber > 0)
        {
            Console.WriteLine("+");
        }

        if (firstNumber * secondNumber * thirdNumber < 0)
        {
            Console.WriteLine("-");
        }

        else if (firstNumber * secondNumber * thirdNumber == 0)
        {
            Console.WriteLine("0");
        }
    }
}
