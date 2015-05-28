using System;

class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter weight on Earth:");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnTheMoon = weightOnEarth * 0.17;
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("Weight on the Moon: {0}", weightOnTheMoon);
    }
}

