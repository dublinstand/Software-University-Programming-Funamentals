using System;

//A marketing company wants to keep record of its employees.Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender(m or f)
//•	Personal ID number(e.g. 8306112507)
//•	Unique employee number(27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.Use descriptive names.Print the data at the console.


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

