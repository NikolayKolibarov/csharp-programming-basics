using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position:");
        int position = int.Parse(Console.ReadLine());
        int option;
        Console.WriteLine("Choose between 1 and 0:");
        while (!int.TryParse(Console.ReadLine(), out option) && (option == 0 || option == 1))
        {
            Console.WriteLine("You can only choose between 1 and 0:");
        }
        Console.WriteLine("");
        Console.Beep();
        bool result = (number & (1 << position)) != 0;
        if ((option == 1 && result) || (option == 1 && !result))
        {
            Console.WriteLine(number);
        }
        else if ((option == 1 && !result) || (option == 0 && result))
	    {
            Console.WriteLine(number ^ (1 << position));
	    }
    }
}

