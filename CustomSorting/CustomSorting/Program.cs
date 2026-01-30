using System ;
using System.Collections.Generic ; 

class Program
{
  static void Main(string[] args)
  {
    List<Students>students = new List<Student>() 
    {
      new Student("Amit" , 20 , 85) ,
      new Student("Riya", 19, 85),
      new Student("Karan", 22, 90),
      new Student("Neha", 18, 88)
    };
    students.sort(new StudentComparer()) ; 
    foreach(var s in students)
    { 
      Console.WriteLine(s.Name + " " + s.Age + " "+ s.Marks) ; 
    }
  }
}