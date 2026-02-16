using System ; 
using System.Collections.Generic ; 
class Jewellery
{
  public string Id {get; set;} 
  public string Type {get; set;} 
  public string Material {get; set;} 
  public int Price {get; set; } 
}

class JewelleryUtility
{
  public Dictionary<string , string>GetJewelleryDetails(string Id)
  {
    Dictionary <string , string> result = new Dictionary<string , string>() ; 

    int key = int.Parse(Id.Substring(2)) ; 
    if (Program.JewelleryDetails.ContainsKey(key))
    {
       Jewellery j =  Program.JewelleryDetails[key] ; 

       result.Add (j.Id , j.Type + "__" + j.Material  ) ; 
    }

    return result ; 

    
  }

  public Dictionary<string, Jewellery> UpdateJewelleryPrice(string id, int price)
  {
    Dictionary<string, Jewellery>Updated = new Dictionary<string , Jewellery>() ; 
    int key = int.Parse(id.Substring(2)) ; 
    if (Program.JewelleryDetails.ContainsKey(key))
    {
      Program.JewelleryDetails[key].Price = price ; 
      Updated.Add(id , Program.JewelleryDetails[key]) ; 
      
    }
    return Updated ;
  }
}

class Program
{

  public static Dictionary <int , Jewellery> JewelleryDetails = new Dictionary<int , Jewellery>() ;
  public static void Main(string[] args)
  {
    JewelleryUtility jewel = new JewelleryUtility() ; 
    Console.WriteLine("How many Jewelleris")  ; 
    int n = int.Parse(Console.ReadLine()) ; 
    for (int i = 0 ; i < n ; i++)
    {
       Console.WriteLine("Id of the necklace : ") ; 
       string id = Console.ReadLine() ; 
       Console.WriteLine ("type of the necklace : ") ; 
       string type = Console.ReadLine() ; 
       Console.WriteLine("Materal Of the necklace : ") ; 
       string material = Console.ReadLine() ; 
       Console.WriteLine("Price of the necklace : ") ; 
       int price = int.Parse (Console.ReadLine()) ; 

       int key = int.Parse(id.Substring(2)) ; 

       JewelleryDetails.Add(key , new Jewellery
       {
         Id = id , 
         Type = type , 
         Material = material , 
         Price = price

       }) ;
    }

    bool exit = false ; 
    while (!exit)
    {
      Console.WriteLine("1. Get Jewellery Details");
      Console.WriteLine("2. Update Price");
      Console.WriteLine("3. Exit");
      Console.WriteLine("Enter your choice");

      int choice = int.Parse(Console.ReadLine()) ;

      switch (choice)
      {
        case 1 : 
        Console.WriteLine("Enter the Jewellery Id : ") ;
        string id1 = Console.ReadLine() ; 

        var details = jewel.GetJewelleryDetails(id1) ; 
        if (details.Count == 0)
          {
            Console.WriteLine("Id not found ") ; 
          }
        else
          {
            foreach(var d in details)
            {
              Console.WriteLine(d.Key + "->" + d.Value) ; 
            }
          }
          break ; 
        case 2 : 
        Console.WriteLine("Enter the Jewellery Id : ") ;
        string id2 = Console.ReadLine() ; 
        Console.WriteLine("Enter the Price :") ;
        int price = int.Parse(Console.ReadLine()) ; 

        var updated = jewel.UpdateJewelleryPrice(id2 , price) ;
        foreach(var u in updated)
          {
              Jewellery j = u.Value ; 
              Console.WriteLine(j.Id + j.Type + j.Material + j.Price) ; 
          }
          break ; 
        case 3 : 
        Console.WriteLine("Thank You") ; 
        exit = true ; 
        break ; 
      }

  }
}
}