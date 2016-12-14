using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        long personalID = long.Parse(Console.ReadLine());
        int employeeNum = int.Parse(Console.ReadLine());

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine($"Personal ID: {personalID}");
        Console.WriteLine($"Unique Employee number: {employeeNum}");
    }
}

