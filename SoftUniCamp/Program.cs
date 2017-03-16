using System;

class Program
{
    static void Main()
    {
        int groupsCount = int.Parse(Console.ReadLine());

        double peopleWithCar = 0;
        double peopleWithBus = 0;
        double peopleWithSmallBus = 0;
        double peopleWithLargeBus = 0;
        double peopleWithTrain = 0;

        for (int i = 0; i < groupsCount; i++)
        {
            int currentGroupPeopleCount = int.Parse(Console.ReadLine());

            if (currentGroupPeopleCount <= 5)
            {
                peopleWithCar += currentGroupPeopleCount;
            }
            else if (currentGroupPeopleCount >= 6 && currentGroupPeopleCount <= 12)
            {
                peopleWithBus += currentGroupPeopleCount;
            }
            else if (currentGroupPeopleCount >= 13 && currentGroupPeopleCount <= 25)
            {
                peopleWithSmallBus += currentGroupPeopleCount;
            }
            else if (currentGroupPeopleCount >= 26 && currentGroupPeopleCount <= 40)
            {
                peopleWithLargeBus += currentGroupPeopleCount;
            }
            else
            {
                peopleWithTrain += currentGroupPeopleCount;
            }
        }

        double totalPeopleCount = peopleWithCar + peopleWithBus + peopleWithSmallBus + peopleWithLargeBus + peopleWithTrain;

        Console.WriteLine("{0:F2}%", (peopleWithCar / totalPeopleCount) * 100);
        Console.WriteLine("{0:F2}%", (peopleWithBus / totalPeopleCount) * 100);
        Console.WriteLine("{0:F2}%", (peopleWithSmallBus / totalPeopleCount) * 100);
        Console.WriteLine("{0:F2}%", (peopleWithLargeBus / totalPeopleCount) * 100);
        Console.WriteLine("{0:F2}%", (peopleWithTrain / totalPeopleCount) * 100);


    }
}
