using System;
using System.Collections.Generic;

namespace University_Course_Registration_System
{
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Course Code: ");
                            string cCode = Console.ReadLine();

                            Console.Write("Course Name: ");
                            string cName = Console.ReadLine();

                            Console.Write("Credits: ");
                            int credits = int.Parse(Console.ReadLine());

                            Console.Write("Max Capacity: ");
                            int capacity = int.Parse(Console.ReadLine());

                            system.AddCourse(cCode, cName, credits, capacity);
                            break;

                        case "2":
                            Console.Write("Student ID: ");
                            string sId = Console.ReadLine();

                            Console.Write("Student Name: ");
                            string sName = Console.ReadLine();

                            Console.Write("Major: ");
                            string major = Console.ReadLine();

                            Console.Write("Max Credits: ");
                            int maxCredits = int.Parse(Console.ReadLine());

                            system.AddStudent(sId, sName, major, maxCredits);
                            break;

                        case "3":
                            Console.Write("Student ID: ");
                            string regStudentId = Console.ReadLine();

                            Console.Write("Course Code: ");
                            string regCourseCode = Console.ReadLine();

                            system.RegisterStudentForCourse(regStudentId, regCourseCode);
                            break;

                        case "4":
                            Console.Write("Student ID: ");
                            string dropStudentId = Console.ReadLine();

                            Console.Write("Course Code: ");
                            string dropCourseCode = Console.ReadLine();

                            system.DropStudentFromCourse(dropStudentId, dropCourseCode);
                            break;

                        case "5":
                            system.DisplayAllCourses();
                            break;

                        case "6":
                            Console.Write("Student ID: ");
                            string scheduleStudentId = Console.ReadLine();

                            system.DisplayStudentSchedule(scheduleStudentId);
                            break;

                        case "7":
                            system.DisplaySystemSummary();
                            break;

                        case "8":
                            exit = true;
                            Console.WriteLine("Exiting system...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
