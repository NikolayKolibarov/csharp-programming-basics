using System;

class PlayWithIntDoubleString
{
    static void Main()
    {

        int option;
        int intOption;
        double doubleOption;
        Console.WriteLine("Please choose a type: \n1 --> int \n2 --> double \n3 --> string");
        while (!(int.TryParse(Console.ReadLine(), out option) && option > 0 && option <= 3))
        {
            Console.WriteLine("You must choose an option by entering 1, 2 or 3: ");
        } 

                Console.WriteLine("");
                Console.Beep();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter an integer: ");
                        while (!int.TryParse(Console.ReadLine(), out intOption))
                        {
                            Console.WriteLine("You must enter an integer: ");
                        }

                        Console.WriteLine(intOption + 1);
                        break;

                    case 2:
                        Console.WriteLine("Please enter a double: ");
                        while (!double.TryParse(Console.ReadLine(), out doubleOption))
                        {
                            Console.WriteLine("You must enter a double: ");
                        }
                        Console.Beep();
                        Console.WriteLine(doubleOption + 1);
                        break;

                    case 3:
                        Console.WriteLine("Please enter a string: ");
                        string stringOption = Console.ReadLine();
                        Console.Beep();
                        Console.WriteLine("{0}*",stringOption);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

    }
}

