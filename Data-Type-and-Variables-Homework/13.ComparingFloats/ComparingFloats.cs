using System;


class ComparingFloats
{
    static void Main()
    {
        float firstNumberA = 5.3f;
        float firstNumberB = 6.01f;
        double secondNumberA = 5.00000001;
        double secondNumberB = 5.00000003;
        decimal thirdNumberA = -0.0000007m;
        decimal thirdNumberB = 0.00000007m;
        double fourthNumberA = -4.999999;
        double fourthNumberB = -4.999998;
        Console.WriteLine("First pair: {0} & {1} \nSecond pair: {2} & {3} \nThird pair: {4} & {5} \nFourth pair: {6} & {7}", firstNumberA, firstNumberB, secondNumberA, secondNumberB, thirdNumberA, thirdNumberB, fourthNumberA, fourthNumberB);
        Console.WriteLine("");
        CompareNumbers((decimal)firstNumberA, (decimal)firstNumberB);
        CompareNumbers((decimal)secondNumberA, (decimal)secondNumberB);
        CompareNumbers(thirdNumberA, thirdNumberB);
        CompareNumbers((decimal)fourthNumberA, (decimal)fourthNumberB);
    }

    private static void CompareNumbers(decimal numberA, decimal numberB)
    {
        if (Math.Abs(numberA - numberB) < 0.000001m)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }

}

