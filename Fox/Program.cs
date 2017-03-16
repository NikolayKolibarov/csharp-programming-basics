using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int stars = 1;
        int dashes = 2 * n - 1;
        int middleStars = n / 2;
        int insideMiddleStars = n; 

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('*',stars),new string('-',dashes));
            stars++;
            dashes -= 2;
        }

        for (int i = 0; i < n/3; i++)
        {
            Console.WriteLine("|{0}\\{1}/{0}|", new string('*',middleStars), new string('*',insideMiddleStars));
            middleStars++;
            insideMiddleStars -= 2;
        }
        dashes = 1;
        stars = 2 * n - 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string('-', dashes), new string('*', stars));
            stars -= 2;
            dashes++;
        }
    }
}

