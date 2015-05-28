using System;

class AgeAfter10Years
{
    static void Main(string[] args)
    {
        DateTime birthDay = new DateTime(1998, 10, 09);
        DateTime todaysDate = DateTime.Now;
        var MyAge = todaysDate.Year - birthDay.Year;
        Console.WriteLine("My Age is:" + MyAge);
        var myFutureAge = MyAge + 10;
        Console.WriteLine("My Age in 10 years will be:" + myFutureAge);
    }
}

