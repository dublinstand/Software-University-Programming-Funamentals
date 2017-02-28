using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

//At the Software University we often organize programming courses for beginners in different towns.We usually run a registration form and after the registration finishes, we distribute the students into study groups.Groups have different sizes in each town.
//You are given a report holding the registrations for each town and the lab capacity (seats count) for each town.It comes in the following format:
//•	Town name => X seats (where X is the capacity of the training lab in this town).
//o Student name | student email | registration date(in format day-month-year). The month name is given as 3 letters in English, e.g. “May”, “Aug” or “Nov”.
//o The next student come after the first, etc.
//•	Then the next town and its students come, etc.
//•	The input ends by a line holding “End”.
//The input comes in the following structure:
//Town1 => X seats
//Student1 Name | student1_email @somewhere.com | day-month-year
//Student2 Name | student2_email @somewhere.com | day-month-year
//Student3 Name | student3_email @somewhere.com | day-month-year
//…
//Town2 => X seats
//Student1 Name | student1_email @somewhere.com | day-month-year
//Student2 Name | student2_email @somewhere.com | day-month-year
//…
//End
//Your task is to create and print the study groups for each town as follows:
//•	For each town create and print one or several study groups (depends of the number or registered students and the capacity of the lab in this town).
//•	For each town order the students by registration date(ascending), then by name(ascending) then by email(ascending), then fill them into groups.If the students are less or equal to the lab capacity, create only one group.When the students are more than the lab capacity, distribute them in multiple groups.
//•	Print all groups ordered by town (ascending) in the following format:
//o Created G groups and T towns:
//o Town1 => email1, email2, …
//o Town1 => email1, email2, …
//o	…
//o Town2 => email1, email2, …
//o	…


class StudentGroups
{
    static void Main()
    {
        List<Town> towns = new List<Town>();
        List<Group> groups = new List<Group>();

        towns = ReadTownsAndStudents();
        groups = DistributeStudentsIntoGroups(towns);

        PrintGroups(groups);

    }

    private static void PrintGroups(List<Group> groups)
    {
        int townCount = groups.Select(x => x.Town).Distinct().Count();
        Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, townCount);

        foreach (Group group in groups.OrderBy(x => x.Town.Name))
        {
            string[] emails = group.Students.Select(x => x.Email).ToArray();
            Console.WriteLine("{0} => {1}", group.Town.Name, string.Join(", ", emails));
        }
    }

    private static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
    {
        List<Group> groups = new List<Group>();

        foreach (Town town in towns.OrderBy(x => x.Name))
        {
            IEnumerable<Student> students = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);

            while (students.Any())
            {
                Group group = new Group() { Town = town };
                group.Students = students.Take(group.Town.SeatsCount).ToList();
                students = students.Skip(group.Town.SeatsCount);
                groups.Add(group);
            }
        }
        return groups;
    }

    private static List<Town> ReadTownsAndStudents()
    {
        List<Town> towns = new List<Town>();

        while (true)
        {
            string token = Console.ReadLine();

            if (token.Contains("="))
            {
                Town town = new Town();
                town.Students = new List<Student>();

                string[] newToken = token.Split('=');
                town.Name = newToken[0].Trim();

                string[] secondToken = newToken[1].Split(' ');
                town.SeatsCount = int.Parse(secondToken[1]);

                towns.Add(town);
            }
            else if (token.Contains("|"))
            {
                Student student = new Student();

                string[] newToken = token.Split('|');

                student.Name = newToken[0].Trim();
                student.Email = newToken[1].Trim();
                student.RegistrationDate = DateTime.ParseExact(newToken[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                towns.Last().Students.Add(student);
            }
            else if (token == "End")
            {
                break;
            }
        }

        return towns;
    }
}

class Student
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime RegistrationDate { get; set; }
}

class Town
{
    public string Name { get; set; }
    public int SeatsCount { get; set; }
    public List<Student> Students { get; set; }
}

class Group
{
    public Town Town { get; set; }
    public List<Student> Students { get; set; }
}



