using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company Address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Fax number: ");
        string faxNumber = Console.ReadLine();
        if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }
        Console.WriteLine("Web site: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Manager last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Manager age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone: ");
        string managerNumber = Console.ReadLine();
        Console.WriteLine("");
        Console.Beep();
        Console.WriteLine("{0} \nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} {6} (age: {7}, tel. {8})",companyName ,companyAddress ,phoneNumber ,faxNumber ,webSite ,firstName ,lastName ,age ,managerNumber);
    }
}

