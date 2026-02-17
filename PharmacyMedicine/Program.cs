using System ;
using System.Collection.Generic ; 

class InvalidPriceException : Exception
{
  public InvalidpriceException(string msg) : base(msg) { } 
}

class DuplicateMedicineException : Exception
{
  public DuplicateMedicineException(string msg) : base (msg ){ }
}

class InvalidExpiryYearException : Exception
{
  public InvalidExpiryYearException (string msg) : base (msg) { }
 
}

class MedicineNotFoundException : Exception
{
  public MedicineNotFoundException(string msg) : base (msg) { }
}

class Medicine
{
  public string Id {get; set ;}
  public string Name {get ; set ;} 
  public int Price {get; set ;} 
  public int ExpiryYear {get; set ; }
}

class MedicineUtilty
{
   SortedDictionary<int, List<Medicine>> medicines = new SortedDictionary<int, List<Medicine>>();

   public void AddMedicne (Medicine Medicine)
  {
    if (Medicine.Price < 0 )
    {
      throw new  InvalidPriceException("Price Must be Positive ") ; 
    }

    foreach( var list in medicines)
    {
      foreach(var m in list.Value)
    {
      if (m.Id == Medicine.Id)
      {
        throw new DuplicateMedicineException ("Medicine already exist") ; 
      }
    }
    }
    if (!medicines.ContainsKey(Medicine.ExpiryYear))
    {
      medicines[Medicine.ExpiryYear] = new List <Medicine>() ; 
       
    }
    medicines[Medicine.ExpiryYear].Add(Medicine) ;
  }

  public void GetMedicine()
  {
     foreach (var year in medicines)
    {
      foreach(var m  in medicines[year])
      {
         Console.WriteLine($"Details: {m.Id} {m.Name} {m.Price} {m.ExpiryYear}");
      }
    }
  }

  public void UpdatedMedicinePrice(string id , int newPrice)
  {
     foreach(var pair in medicines.Keys)
    {
      foreach(var m in medicines[pair])
      {
        if (m.Id == id)
        {
          m.Price = newPrice ; 
        }
       
      }
    }
  }

}

