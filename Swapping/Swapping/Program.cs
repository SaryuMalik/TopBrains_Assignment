using System;
using System.Collections.Generic;

public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }
}

public class StudentUtility
{
    public Dictionary<string, string> GetStudentDetails(string id)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();

        foreach (Student s in Program.studentDetails.Values)
        {
            if (s.Id == id)
            {
                result.Add(s.Id, s.Name + "_" + s.Course);
                return result;
            }
        }
        return result;
    }

    public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
    {
        Dictionary<string, Student> result = new Dictionary<string, Student>();

        foreach (Student s in Program.studentDetails.Values)
        {
            if (s.Id == id)
            {
                s.Marks = marks;
                result.Add(s.Id, s);
                return result;
            }
        }
        return result;
    }
}

public class Program
{
    public static Dictionary<int, Student> studentDetails = new Dictionary<int, Student>();

    public static void Main()
    {
        studentDetails.Add(1, new Student { Id = "ST01", Name = "Alice", Course = "DataScience", Marks = 85 });
        studentDetails.Add(2, new Student { Id = "ST02", Name = "Bob", Course = "AI", Marks = 78 });
        studentDetails.Add(3, new Student { Id = "ST03", Name = "Charlie", Course = "ML", Marks = 90 });

        StudentUtility util = new StudentUtility();
        bool run = true;

        while (run)
        {
            Console.WriteLine("1. Get Student Details");
            Console.WriteLine("2. Update Marks");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter the student id: ");
                string id = Console.ReadLine();

                var result = util.GetStudentDetails(id);
                if (result.Count == 0)
                    Console.WriteLine("Student id not found");
                else
                    foreach (var r in result)
                        Console.WriteLine(r.Key + "   " + r.Value);
            }
            else if (choice == 2)
            {
                Console.Write("Enter the student id: ");
                string id = Console.ReadLine();
                Console.Write("Enter the marks: ");
                int marks = int.Parse(Console.ReadLine());

                var result = util.UpdateStudentMarks(id, marks);
                if (result.Count == 0)
                    Console.WriteLine("Student id not found");
                else
                    foreach (var r in result)
                        Console.WriteLine(r.Key + "   " + r.Value.Marks);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thank you");
                run = false;
            }
        }
    }
}
