using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter Age:");
        sbyte age = sbyte.Parse(Console.ReadLine());
        Console.WriteLine("Enter gender (m/f):");
        string gender = Console.ReadLine();
        Console.WriteLine("Enter Personal ID:");
        string id = Console.ReadLine();
        Console.WriteLine("Enter Unique Employee Number(2756****):");
        uint employeeNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("\nEmployee Data: \n"
+ "First name: {0} \n"
+ "Last name: {1} \n"
+ "Age: {2} \n"
+ "Gender: {3} \n"
+ "Personal ID number: {4} \n"
+ "Unique Enmployee number: {5}",
firstName, lastName, age, gender, id, employeeNumber);
    }
}

