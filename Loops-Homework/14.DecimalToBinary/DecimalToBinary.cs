using System;

class DecimalToBinary
{
    static void Main()
    {
        long decNum;
        string binNum = "";
        Console.WriteLine("Enter a number different from 0: ");
        while (!long.TryParse(Console.ReadLine(),out decNum))
        {
            Console.WriteLine("You must enter a number: ");
        }

        if (decNum == 0)
        {
            Console.WriteLine("You can't enter 0.");
        }

        else
        {
            while (decNum != 0)
            {
                int remainder = (int)decNum % 2;
                decNum /= 2;
                binNum = remainder + binNum;
            }
        }

        Console.WriteLine(binNum);
    }
}

