using System;
using System.Collections.Generic;
using System.Linq;

//Define a class Student, which holds the following information about students: name, list of grades and average grade(calculated property, read-only). 
//A single grade will be in range[2…6], e.g. 3.25 or 5.50.
//Read a list of students and print the students that have average grade ≥ 5.00 ordered by name(ascending), then by average grade(descending). 
//Print the student name and the calculated average grade.


class AverageGrades
{
    static void Main()
    {
        int studentNum = int.Parse(Console.ReadLine());
        Student[] students = new Student[studentNum];

        for (int i = 0; i < studentNum; i++)
        {
            string input = Console.ReadLine();
            students[i] = ReadStudent(input);
        }

        foreach (Student student in students.Where(x => x.averageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.averageGrade))
        {
            Console.WriteLine("{0} -> {1:f2}", student.Name, student.averageGrade);
        }


    }

    public static Student ReadStudent(string input)
    {
        string[] tokens = input.Split(' ');
        List<double> grades = new List<double>();

        foreach (var token in tokens.Skip(1))
        {
            grades.Add(double.Parse(token));
        }

        return new Student { Name = tokens[0], Grades = grades};
    }
    
}

class Student
{
    public string Name { get; set; }

    public List<double> Grades { get; set; }

    public double averageGrade { get { return Grades.Average(); } }

}

