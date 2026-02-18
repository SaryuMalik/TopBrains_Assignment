using System ;
using System.Collections.Generic ;



class InvalidGpaException : Exception
{
  public InvalidGpaException (string msg) : base (msg) { }
}

class DuplicateStudentException : Exception
{
  public DuplicateStudentException (string msg) : base(msg){ }
}

class StudentNotFoundException : Exception
{
  public StudentNotFoundException (string msg) : base (msg) { }
}
class Student
{
  public string Id {get; set ;} 
  public string Name {get ; set ; } 
  public double Gpa  {get; set;}
}

class StudentUtility
{
  SortedDictionary<double, List<Student>>store = new SortedDictionary<double , List<Student>>() ; 

  public void AddStudent(Student student)
  {
    if (student.Gpa < 0 || student.Gpa > 10)
    {
      throw new InvalidGpaException ("Invalid Gpa") ; 
    }

    foreach (var pair in store)
    {
      foreach(var s in pair.Value)
      {
        if (s.Id == student.Id)
        {
          throw new DuplicateStudentException("Student Already exist") ;
        }
      }
    }
    
    if (!store.ContainsKey(student.Gpa))
    {
       store[student.Gpa] = new List<Student>() ;
    }

    store[student.Gpa].Add(student) ; 

  }

  public void DisplayStudents()
  {
    foreach(var pair in store)
    {
      foreach( var s in pair.Value)
      {
        Console.WriteLine($"Display Details -> ID : {s.Id} Name : {s.Name} Gpa : {s.Gpa} ") ; 
      }
    }
  }

  public void UpdateGpa(string id  , double gpa)
  {
      if (gpa < 0 || gpa > 10)
    {
      throw new InvalidGpaException ("Invalid Gpa for Updation ") ; 
    }

    foreach(var pair in store)
    {
      foreach (var s in pair.Value)
      {
         if (s.Id == id )
        {
          s.Gpa = gpa ; 
          return ; 
        }
      }
    }

    throw new StudentNotFoundException("Student not found");

  }



}


class Program
{
  static void Main(string[] args)
  {
    StudentUtility utility = new StudentUtility() ; 
    bool exit = false ; 
    while (!exit)
    {
      Console.WriteLine("1 -> Display Ranking ") ; 
      Console.WriteLine("2 -> Update Gpa ") ; 
      Console.WriteLine("3 -> Add Student ") ; 
      Console.WriteLine("4 ->Exit ") ; 
      
      Console.WriteLine(" Enter the Choice : ") ; 
      int choice = int.Parse(Console.ReadLine()) ; 
      try{
      switch(choice)
      {
        case 1 : 
        utility.DisplayStudents() ; 
        break ; 
        case 2 : 
        string id = Console.ReadLine() ; 
        double gpa = double.Parse(Console.ReadLine()) ; 
        utility.UpdateGpa(id , gpa) ; 
        break ; 
        case 3 : 
        string newStudent = Console.ReadLine() ;
        string[] studentarr = newStudent.Split(" ") ; 
        
          
        Student stu = new Student ()
        {
          Id = studentarr[0] ,
          Name = studentarr[1] ,
          Gpa  = double.Parse(studentarr[2] )  
        } ;

        utility.AddStudent(stu) ; 
        break ;

        case 4 : 
        Console.WriteLine("Thank you") ; 
        exit = true ; 
        break ; 
        

      }
      }

      catch(Exception ex)
      {
        Console.WriteLine(ex.Message) ; 
      }

    }
  }
}
