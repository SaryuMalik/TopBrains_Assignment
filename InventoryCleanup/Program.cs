using System ; 
using System.Text ; 
using System.Globalization ; 
namespace InventoryCleanup
{
  class Program {
  static void Main(string[] args)
  {
    string GivenString ; 
    GivenString = Console.ReadLine() ; 
    GivenString = GivenString.Trim() ; 
    StringBuilder newString =  new StringBuilder() ; 
    newString.Append(GivenString[0]) ; 
    for (int i = 1 ; i < GivenString.Length ; i++)
    {
       if (GivenString[i] != GivenString[i-1])
      {
          newString.Append(GivenString[i]) ; 
      }
    } 

    string FinalString = newString.ToString() ; 
    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
    string result = textInfo.ToTitleCase(FinalString.ToLower());

    Console.WriteLine(result);
  }
  }
}