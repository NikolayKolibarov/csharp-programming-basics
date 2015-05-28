using System;


class BankAccData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Prodanov";
        decimal balance = 152675.5432M;
        string bankName = "DSK Bank";
        string ibnNumber = "BG01 023 000 1234 5678 901 23";
        long creditCard1 = 4000123456789123L;
        long creditCard2 = 5000987654321234L;
        long creditCard3 = 6000012345432112L;
        Console.WriteLine("Personal Information: {0} {1} {2} \nAmount of money: {3} \nBank: {4} \nIBN: {5} \nFirst Credit card number: {6} \nSecond Credit card number: {7} \nThird Credit card number: {8}", firstName, middleName, lastName, balance, bankName, ibnNumber, creditCard1, creditCard2, creditCard3);
    }
}

