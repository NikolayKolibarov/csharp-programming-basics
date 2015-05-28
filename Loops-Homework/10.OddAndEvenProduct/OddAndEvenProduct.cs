using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter numbers: ");
        string input = Console.ReadLine();
        string[] array = input.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        Console.WriteLine();
        Console.Beep();
        for (int i = 0; i < array.Length; i++)
        {
            int number = int.Parse(array[i]);
            if (i % 2 == 0 || i == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd product = {0}", oddProduct);
            Console.WriteLine("even product = {0}", evenProduct);
        }
    }
}


