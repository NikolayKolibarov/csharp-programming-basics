using System;

class BonusScore
{
    static void Main()
    {
        int score, result;
        Console.WriteLine("Enter a value for score: ");
        while (!int.TryParse(Console.ReadLine(), out score))
        {
            Console.WriteLine("You must enter an integer: ");
        }
        Console.Beep();
        if (score >= 1 && score <= 3)
        {
            result = score * 10;
            Console.WriteLine("{0}", result);
        }

        if (score >= 4 && score <= 6)
        {
            result = score * 100;
            Console.WriteLine("{0}", result);
        }

        if (score >= 7 && score <= 9)
        {
            result = score * 1000;
            Console.WriteLine("{0}", result);
        }

        else if (score == 0 || score > 9)
        {
            Console.WriteLine("Invalid score.");
        }
    }
}

