using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime time;
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        Console.WriteLine("Enter time in format \"hh:mm tt AM/PM\":");
        string date = Console.ReadLine();
        if (DateTime.TryParseExact(date, "h:mm tt", enUS, DateTimeStyles.None, out time ))
        {
            if ((time > startTime || time < endTime))
            {
                Console.WriteLine("Beer time");
            }

            else
            {
                Console.WriteLine("Non-beer time");
            }
           
        }

        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

