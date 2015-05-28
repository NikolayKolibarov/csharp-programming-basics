using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a four-digit number");
        int number = int.Parse(Console.ReadLine());
        int fourthDigit = number % 10;
        int thirdDigitRemainder = number / 10;
        int thirdDigit = thirdDigitRemainder % 10;
        int secondDigitRemainder = number / 100;
        int secondDigit = secondDigitRemainder % 10;
        int firstDigitRemainder = number / 1000;
        int firstDigit = firstDigitRemainder % 10;
        int result = fourthDigit + thirdDigit + secondDigit + firstDigit;
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("Sum of digits: {0}",result);
        Console.WriteLine("Reversed order: {0}{1}{2}{3}",fourthDigit ,thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("First and Last Digit Exchanged: {0}{1}{2}{3}",fourthDigit ,secondDigit, thirdDigit, firstDigit);
        Console.WriteLine("Second and Third Digit Exchanged: {0}{1}{2}{3}",firstDigit ,thirdDigit ,secondDigit ,fourthDigit);
    }
}

