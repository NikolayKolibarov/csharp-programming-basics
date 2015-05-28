using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number: ");
        string binNum = Console.ReadLine();
        long decNum = 0;
        int power = 1;

        for (int i = binNum.Length - 1; i >= 0; i--)
        {
            int num = binNum[i] - 48;
            Console.WriteLine(num);
            decNum += num * power;
            power *= 2;
        }
        Console.WriteLine(decNum);
    }
}

