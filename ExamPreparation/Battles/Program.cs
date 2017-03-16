using System;


class Program
{
    static void Main()
    {
        int firstPlayerPokemonsCount = int.Parse(Console.ReadLine());
        int secondPlayerPokemonsCount = int.Parse(Console.ReadLine());
        int maxBattlesCount = int.Parse(Console.ReadLine());

        int currentBattle = 1;

        for (int firstPlayerPokemon = 1; firstPlayerPokemon <= firstPlayerPokemonsCount; firstPlayerPokemon++)
        {
            for (int secondPlayerPokemon = 1; secondPlayerPokemon <= secondPlayerPokemonsCount; secondPlayerPokemon++)
            {
                Console.Write($"({firstPlayerPokemon} <-> {secondPlayerPokemon}) ");

                if (currentBattle == maxBattlesCount)
                {
                    return;
                }

                currentBattle++;
            }
        }

        Console.WriteLine();

    }

}
