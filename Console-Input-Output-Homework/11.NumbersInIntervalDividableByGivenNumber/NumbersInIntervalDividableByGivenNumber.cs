using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number for starting point: ");
        int startNum, endNum;
        int p = 0;
        while (!int.TryParse(Console.ReadLine(), out startNum) || startNum < 0)
        {
            Console.WriteLine("You have to enter a positive integer: ");
        }
        Console.WriteLine("Enter number for ending point: ");
        while (!int.TryParse(Console.ReadLine(), out endNum) || endNum <0)
        {
            Console.WriteLine("You have to enter a positive integer: ");
        }
        for (int i = startNum; i <= endNum; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        if (p > 0)
        {
            Console.Beep();
            Console.WriteLine("Numbers that can be divided by 5 with no remainder: {0}", p);
        }
        else
        {
            Console.Beep();
            Console.WriteLine("-");
        }
    }
}

