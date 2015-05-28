using System;


class NullValues
{
    static void Main()
    {
        int? i = null;
        double? d = null;
        Console.WriteLine("Null Value:" + i);
        Console.WriteLine("Null Value:" + d);
        Console.WriteLine("");
        i += 15;
        d += 1.5d;
        Console.WriteLine("Null Value + Number:" + i);
        Console.WriteLine("Null Value + Number:" + d);
    }
}

