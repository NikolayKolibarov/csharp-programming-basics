using System;

namespace DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            string inputValue = Console.ReadLine();
            double digit;
            bool parseSuccess = double.TryParse(inputValue, out digit);
            Console.Write(parseSuccess ? inputValue : "{0} not a digit!", inputValue);

            switch (inputValue)
            {
                case "0": Console.WriteLine(" zero"); break;
                case "1": Console.WriteLine(" one"); break;
                case "2": Console.WriteLine(" two"); break;
                case "3": Console.WriteLine(" three"); break;
                case "4": Console.WriteLine(" four"); break;
                case "5": Console.WriteLine(" five"); break;
                case "6": Console.WriteLine(" six"); break;
                case "7": Console.WriteLine(" seven"); break;
                case "8": Console.WriteLine(" eight"); break;
                case "9": Console.WriteLine(" nine"); break;
                default: if ((digit < 0) || (digit > 9))
                    {
                        Console.WriteLine(" not a digit"); ;
                    }
                    break;
            }
        }
    }
}