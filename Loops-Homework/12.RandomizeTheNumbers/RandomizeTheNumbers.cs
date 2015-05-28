using System;

class RandomizeTheNumbers
{
    static void Main()
    {
        int count;
        Console.WriteLine("Enter number count: ");
        while (!int.TryParse(Console.ReadLine(),out count))
        {
            Console.WriteLine("You must enter an integer: ");
        }

        int[] array = new int[count];
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            array[i] = i + 1;
        }

        foreach (int i in array)
        {
            int randomNumber = random.Next(0, count);
            int temp = array[randomNumber];
            array[randomNumber] = array[0];
            array[0] = temp;
        }
        Console.WriteLine(string.Join(" ", array));
    }
}

