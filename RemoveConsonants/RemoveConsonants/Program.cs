using System ;
using System.Text ; 
using System.Collections.Generic ;
namespace RemoveConsonants{
class Program
{
    static void Main(string[] args)
    {
      string PehliString ; 
      string DusriString ; 
      PehliString = Console.ReadLine() ; 
      DusriString = Console.ReadLine() ; 

      HashSet<char>keeper =  new HashSet<char>() ; 
      foreach (char c in DusriString.ToLower())
      {
        keeper.Add(c) ; 
      }

      StringBuilder filtered = new StringBuilder() ; 

      foreach(char c in PehliString)
      {
        char Lower = char.ToLower(c) ; 
        if (isConsonant(Lower) && keeper.Contains(Lower))
        {
          continue ; 
        }

        filtered.Append(c) ;
      }

      StringBuilder result = new StringBuilder() ; 
      result.Append(filtered[0]) ; 
      for (int i = 1 ; i < filtered.Length ; i++)
      {
        if (filtered[i] != filtered[i - 1])
        {
          result.Append(filtered[i]) ; 
        }
      }
       
      Console.WriteLine(result.ToString()) ; 

    }

    static bool isConsonant(char ch)
    {
      return char.IsLetter(ch) && !(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch=='u') ;  
    }
}
}