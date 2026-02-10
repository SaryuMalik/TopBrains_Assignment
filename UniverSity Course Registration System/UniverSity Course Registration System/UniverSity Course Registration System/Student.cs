using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {

          
            int sum = 0 ; 
            foreach(var ch in RegisteredCourses)
            {
                sum +=  ch.Credits ; 
            }

            return sum ; 
            // TODO: Return sum of credits of all RegisteredCourses

        }

        public bool CanAddCourse(Course course)
        {
            // TODO:
            // 1. Course should not already be registered
            // 2. Total credits + course credits <= MaxCredits
            // 3. Course prerequisites must be satisfied

            Course ch = new Course() ; 

            if (RegisterdCourses.Any(c=>c.CourseCode == course.CourseCode)) return false ; 
            int ans = GetTotalCredits() ; 
            if ((ans + course.Credits) > MaxCredits) return false ; 
            if (!course. HasPrerequisites(CompletedCourses) ) return false ; 

            return true ; 



            //throw new NotImplementedException();
        }

        public bool AddCourse(Course course)
        {
            // TODO:
            // 1. Call CanAddCourse
            // 2. Check course capacity
            // 3. Add course to RegisteredCourses
            // 4. Call course.EnrollStudent()
            if (CanAddCourse(course) && !course.IsFull())
            {
                course.EnrollStudent() ; 
                RegisteredCourses.Add(course) ; 
                return true ; 
            }

            return false ; 
           
        }

        public bool DropCourse(string courseCode)
        {
            // 1. Find course by code
            Course course = RegisteredCourses
                            .FirstOrDefault(c => c.CourseCode == courseCode);

            // Course not found
            if (course == null)
                return false;

            // 2. Remove from RegisteredCourses
            RegisteredCourses.Remove(course);

            // 3. Call course.DropStudent()
            course.DropStudent();

            return true;
        }


        public void DisplaySchedule()
        {
            // TODO:
            // Display course code, name, and credits
            // If no courses registered, display appropriate messagepublic void DisplaySchedule()
{
    if (RegisteredCourses.Count == 0)
    {
        Console.WriteLine("No courses registered.");
        return;
    }

    Console.WriteLine("Registered Courses:");
    foreach (var course in RegisteredCourses)
    {
        Console.WriteLine(
            $"{course.CourseCode} - {course.CourseName} ({course.Credits} credits)"
        );
    }
}

            
            throw new NotImplementedException();
        }
    }
}
