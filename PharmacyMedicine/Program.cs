using System ;
using System.Collections.Generic ; 

class InvalidPriceException : Exception
{
  public InvalidPriceException(string msg) : base(msg) { } 
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

class MedicineUtility
{
   SortedDictionary<int, List<Medicine>> medicines = new SortedDictionary<int, List<Medicine>>();

   public void AddMedicine (Medicine Medicine)
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
      foreach(var m  in year.Value)
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

class Program
{
  static void Main(string[] args)
  {
    MedicineUtility utility = new MedicineUtility() ; 
    bool exit = false ; 
    try{
    while (!exit)
    {
      Console.WriteLine("1 -> Display Ranking ") ; 
      Console.WriteLine("2 -> Update Gpa ") ; 
      Console.WriteLine("3 -> Add Student ") ; 
      Console.WriteLine("4 ->Exit ") ; 
      
      Console.WriteLine(" Enter the Choice : ") ; 
      int choice = int.Parse(Console.ReadLine()) ;
      switch (choice)
        {
          case 1 : 
          utility.GetMedicine(); 
          break ; 
          case 2 : 
          string id = Console.ReadLine() ; 
          int newPrice = int.Parse(Console.ReadLine()) ; 
          utility.UpdatedMedicinePrice(id , newPrice) ;
          break ;
          case 3 :
          string newStudent = Console.ReadLine() ; 
          string[] newStudent1 = newStudent.Split(" ") ; 
          Medicine stu = new Medicine
          {
            Id = newStudent1[0] ,
            Name = newStudent1[1] ,
            Price = int.Parse(newStudent1[2]) 
          };

          utility.AddMedicine(stu) ;
          break ;

          case 4 : 
          Console.WriteLine("Thank You") ; 
          exit = true ; 
          break ; 

        }
        
    }
    }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message) ; 
      }
    }
  }


