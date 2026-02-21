using System ;
class Program
{
  static void Main(string[] args)
  {
    string given = Console.ReadLine() ; 
    string[] separate = given.Split(" , ") ; 
    float[]new1 =  new float[separate.Length]; 
    for(int i = 0 ; i < separate.Length ; i++)
    {
       
      new1[i] = Convert.ToSingle(separate[i]) ; 
      Console.WriteLine(new1[i]) ; 
     
    }
  }
}