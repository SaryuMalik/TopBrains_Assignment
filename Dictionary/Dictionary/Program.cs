using System ;
using System.Collections.Generic ; 

namespace Dictionary
{
  class Program {
  public static void Main(string[] args)
  {
     Dictionary<int , int> EmpDetails = new Dictionary<int , int>()
     {
       {1 , 20000} , 
       {4 , 40000} ,
       {5 , 15000}
     }; 
      
    List<int> ids = new List<int>() {1 , 4 , 5} ; 
    int totalSalary = 0 ; 

    foreach (int id in ids)
    {
      if (EmpDetails.ContainsKey(id))
      {
        totalSalary += EmpDetails[id] ; 
      }
    }

    Console.WriteLine(totalSalary) ; 

  }
  }
}
