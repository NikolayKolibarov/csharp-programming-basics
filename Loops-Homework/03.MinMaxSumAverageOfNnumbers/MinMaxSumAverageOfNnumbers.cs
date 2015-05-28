using System;

class MinMaxSumAverageOfNnumbers
{
    static void Main()
    {
        Console.Write("Number count:  ");
        int count = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        double sum = 0;
        double avg;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }
        avg = (double) sum / count;
        Console.WriteLine("Min = " + min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Avg = {0:F2}", avg);
    }
}

