using System;

class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        for (int i = 0; i < 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("{0}: {1}", i, symbol);
        }
    }
}

