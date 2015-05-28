using System;

class StringsAndObjects
{
    static void Main()
    {
        string greeting = "Hello";
        string noun = "World";
        object Mergetool = greeting + " " + noun;
        Console.WriteLine(Mergetool);
        string a;
        a = (string)Mergetool;
        Console.WriteLine(a);
    }
}

