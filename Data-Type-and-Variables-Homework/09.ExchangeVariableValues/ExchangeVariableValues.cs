using System;

class ExchangeVariableValues
{
    static void Main()
    {
        sbyte a = 5;
        sbyte b = 10;
        Console.WriteLine("Before Exchange");
        Console.WriteLine(a);
        Console.WriteLine(b);
        a ^= b;
        b ^= a;
        a ^= b;
        Console.WriteLine("");
        Console.WriteLine("After Exchange");
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

