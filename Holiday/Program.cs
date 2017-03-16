using System;

class Program
{
    static void Main()
    {
        const double adultsTrainTicketCost = 24.99;
        const double studentsTrainTicketCost = 14.99;

        const double adultsBusTicketCost = 32.50;
        const double studentsBusTicketCost = 28.50;

        const double adultsBoatTicketCost = 42.99;
        const double studentsBoatTicketCost = 39.99;

        const double adultsPlaneTicketCost = 70.00;
        const double studentsPlaneTicketCost = 50.00;

        const double hotelRoomPricePerNight = 82.99;

        int adultsCount = int.Parse(Console.ReadLine());
        int studentsCount = int.Parse(Console.ReadLine());
        int nightsCount = int.Parse(Console.ReadLine());
        string transportType = Console.ReadLine();

        double adultsCost = 0;
        double studentsCost = 0;

        switch (transportType)
        {
            case "train":
                adultsCost = adultsCount * adultsTrainTicketCost;
                studentsCost = studentsCount * studentsTrainTicketCost;

                if (studentsCount + adultsCount >= 50)
                {
                    adultsCost /= 2;
                    studentsCost /= 2;
                }

                break;
            case "bus":
                adultsCost = adultsCount * adultsBusTicketCost;
                studentsCost = studentsCount * studentsBusTicketCost;

                break;
            case "boat":
                adultsCost = adultsCount * adultsBoatTicketCost;
                studentsCost = studentsCount * studentsBoatTicketCost;

                break;
            case "airplane":
                adultsCost = adultsCount * adultsPlaneTicketCost;
                studentsCost = studentsCount * studentsPlaneTicketCost;

                break;
            default:
                break;

        }

        double transportCost = (adultsCost + studentsCost) * 2;
        double hotelCost = nightsCount * hotelRoomPricePerNight;
        double commision = (hotelCost + transportCost) * 0.10;
        double   = transportCost + hotelCost + commision;

        Console.WriteLine($"{totalCost:F2}");

    }
}
