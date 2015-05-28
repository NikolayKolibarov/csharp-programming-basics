using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number: ");
        string hexNum = Console.ReadLine();
        long decNumber = 0;
        long power = 1;
        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            int number;
            switch (hexNum[i])
            {
                case 'A': 
                    number = 10;
                    break;
                case 'B':
                    number = 11;
                    break;
                case 'C':
                    number = 12;
                    break;
                case 'D':
                    number = 13;
                    break;
                case 'E':
                    number = 14;
                    break;
                case 'F':
                    number = 15;
                    break;
                default: number = (int)hexNum[i] - 48;
                    break;
            }

            decNumber += number * power;
            power *= 16;
        }
        Console.WriteLine();
        Console.Beep();
        Console.WriteLine(decNumber);
    }
}

