using System;

class DigitAsWord
{
    static void Main()
    {
        int number;
        Console.WriteLine("Enter a number between 0 and 9: ");
        while (!int.TryParse(Console.ReadLine(),out number))
        {
            Console.WriteLine("You must enter a number: ");
        }
        Console.WriteLine("");
        Console.Beep();
        switch (number)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Not a digit");
                break;
        }
    }
}

