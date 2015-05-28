using System;

class Quotes_In_Strings
{
    static void Main()
    {
        string firstCase = "The \"use\" of quotations causes difficulties.";
        string secondCase = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstCase);
        Console.WriteLine(secondCase);
    }
}
