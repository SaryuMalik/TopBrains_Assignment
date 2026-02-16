using System ;
using System.Collections.Generic ; 
class Shipment
{
  public string ShipmentCode {get; set ; }
  public string TransportMode {get; set ; } 

  public double Weight {get ; set ; } 
  public int  StorageDays {get ; set ;} 

}

class ShipMentDetails : Shipment
{
  public bool ValidateShipmentCode(string Sc)
  {
     bool ans = true ; 
     if (Sc.Length != 7) ans =  false ; 
     if (!Sc.StartsWith("GC#")) ans = false ; 
     string numberPart = Sc.Substring(3) ; 
    foreach(char n in numberPart)
    {
      if (!char.IsDigit(n))
      {
        ans =  false ; 
      }
    }

    return ans ; 

  }
  public double CalculateTotalCost(double weight , int storageDays , string TransportMode)
  {
    Dictionary<string , double>Calculate = new Dictionary<string , double>();
    
       Calculate.Add("Sea" , 15.00) ;
       Calculate.Add("Air" , 50.00) ;
       Calculate.Add("Land" , 25.00)  ; 
    
    double Rateperkg = Calculate[TransportMode] ; 
    double ans = weight * Rateperkg + (Math.Sqrt(storageDays))  ; 

    return ans ; 
  }
}

class Program
{
  public static void Main(string[] args)
  {
      ShipMentDetails shipment = new ShipMentDetails() ;
      Console.Write("InputId") ;
      shipment.ShipmentCode = Console.ReadLine() ;
      Console.Write("Mode : ") ;
      shipment.TransportMode = Console.ReadLine() ; 
      Console.Write("Weight: ") ;
      shipment.Weight = double.Parse(Console.ReadLine()) ; 
      Console.Write("Storage : ") ;
      shipment.StorageDays = int.Parse(Console.ReadLine()) ; 
      
      if (shipment.ValidateShipmentCode(shipment.ShipmentCode))
    {
       double ans = shipment.CalculateTotalCost(shipment.Weight , shipment.StorageDays , shipment.TransportMode) ;

       Console.WriteLine ("The Total SHipping Cost Is : " + ans.ToString("F2")) ; 
    }
    else
    {
      Console.WriteLine("Invalid Shippment Code") ; 
    }

  }
}