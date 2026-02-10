using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        // =====================
        // Add Course
        // =====================
        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            if (AvailableCourses.ContainsKey(code))
                throw new ArgumentException("Course code already exists.");

            Course course = new Course(code, name, credits, maxCapacity, prerequisites);
            AvailableCourses.Add(code, course);

            Console.WriteLine($"Course {code} added successfully.");
        }

        // =====================
        // Add Student
        // =====================
        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            if (Students.ContainsKey(id))
                throw new ArgumentException("Student ID already exists.");

            Student student = new Student(id, name, major, maxCredits, completedCourses);
            Students.Add(id, student);

            Console.WriteLine($"Student {name} added successfully.");
        }

        // =====================
        // Register Student
        // =====================
        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return false;
            }

            if (!AvailableCourses.ContainsKey(courseCode))
            {
                Console.WriteLine("Course not found.");
                return false;
            }

            bool result = Students[studentId].AddCourse(AvailableCourses[courseCode]);
            return result;
        }

        // =====================
        // Drop Course
        // =====================
        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return false;
            }

            return Students[studentId].DropCourse(courseCode);
        }

        // =====================
        // Display All Courses
        // =====================
        public void DisplayAllCourses()
        {
            if (AvailableCourses.Count == 0)
            {
                Console.WriteLine("No courses available.");
                return;
            }

            foreach (var course in AvailableCourses.Values)
            {
                Console.WriteLine($"{course.Code} | {course.Name} | Credits: {course.Credits} | Enrolled: {course.EnrolledCount}/{course.MaxCapacity}");
            }
        }

        // =====================
        // Display Student Schedule
        // =====================
        public void DisplayStudentSchedule(string studentId)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Students[studentId].DisplaySchedule();
        }

        // =====================
        // System Summary
        // =====================
        public void DisplaySystemSummary()
        {
            int totalStudents = Students.Count;
            int totalCourses = AvailableCourses.Count;
            double avgEnrollment = totalCourses == 0
                ? 0
                : AvailableCourses.Values.Average(c => c.EnrolledCount);

            Console.WriteLine("===== System Summary =====");
            Console.WriteLine($"Total Students : {totalStudents}");
            Console.WriteLine($"Total Courses  : {totalCourses}");
            Console.WriteLine($"Avg Enrollment: {avgEnrollment:F2}");
        }
    }
}
