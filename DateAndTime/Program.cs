using System ;

class Program
{
  static void Main(string[] args)
  {
    string s = Console.ReadLine() ; 

    DateTime d = DateTime.ParseExact(s , "MM" , null) ; 

    Console.WriteLine(d.ToString("MM")) ; 
  }
}
//var d = dateValue.Select(d=> DateTime.ParseExact(input , "dd-MM-yyyy" , null)).OrderBy(n=>n) ; 