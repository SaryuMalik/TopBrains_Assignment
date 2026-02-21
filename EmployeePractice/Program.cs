using System ;
using System.Collections.Generic ;


class Employee
{
  public int Id ; 
  public string Name ; 
  public int Salary ; 
}

class Company
{
   List<Employee>Emp = new List<Employee>() ;

  public void AddEmployee(Employee employee)
  {

    Emp.Add(employee) ; 
    
  }

  public void GetTotalSalary()
  {
    int sum = 0 ; 
    foreach(var v in Emp)
    {
       sum += v.Salary ; 
    }

    Console.WriteLine(sum) ; 

  }

}
class Program
{
  static void Main(string[] args)
  {
    Company company = new Company() ; 
     Employee e1 = new Employee
    {
        Id = 1,
        Name = "Rahul",
        Salary = 30000
    };

    company.AddEmployee(e1) ; 

    

    Employee e2 = new Employee
    {
        Id = 2,
        Name = "Aman",
        Salary = 45000
    };

     company.AddEmployee(e2) ; 

    Employee e3 = new Employee
    {
        Id = 3,
        Name = "Priya",
        Salary = 50000
    };

     company.AddEmployee(e3) ; 


     company.GetTotalSalary() ; 
    
    

  }
}