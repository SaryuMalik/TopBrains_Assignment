using System ;
using System.Xml.Serialization;
class Book
{
  public string Id {get;set;} 
  public string Title {get;set;} 
  public string Author {get;set;} 
  public int Price {get;set;} 
  public int Stock {get;set;} 


}

class BookUtilityClass
{
  Book b;

  public BookUtilityClass(Book book)
    {
        b = book;
    } 
   public void GetBookDetails()
  {
    Console.WriteLine(b.Id + " " + b.Title + " "  + " " + b.Price + " " + b.Stock) ;  
  }

  public void UpdateBookPrice(int newPrice)
  {
     b.Price = newPrice ; 
     Console.WriteLine("Updated Price ->" + b.Price) ; 
  }

  public void UpdateBookStock(int newStock)
  {
    b.Stock = newStock ; 
    Console.WriteLine("Updated Stock ->" + b.Stock) ; 
  }


}

class Program
{
  public static void Main()
  {
    Book value  = new Book() ; 
    BookUtilityClass ans = new BookUtilityClass(value) ; 
    string store = Console.ReadLine() ; 
    string[] storeAns = store.Split(" ") ;
    value.Id =  storeAns[0] ; 
    value.Title = storeAns[1] ;  
    value.Price = int.Parse(storeAns[2]) ; 
    value.Stock = int.Parse(storeAns[3]) ; 
    bool exit = false ; 
    while (!exit)
    {
      Console.WriteLine("Choice 1 → Display book details") ;
      Console.WriteLine("Choice 2 -> Update price"   ) ; 
      Console.WriteLine("Chocie 3 -> Update Stock ") ; 
      Console.WriteLine("Choice 4 -> Exit ") ; 

      string choose = Console.ReadLine() ; 
      string[]chooseArr = choose.Split(" ") ;
      int newPrice = 0 ; 
      int newStock = 0 ;  
      if (chooseArr[0] == "2")
      {
        newPrice = int.Parse(chooseArr[1]) ; 
      }
      if (chooseArr[0] == "3")
      {
        newStock = int.Parse(chooseArr[1]) ; 
      }
      switch(chooseArr[0])
      {
        case "1" : 
        ans.GetBookDetails() ; 
        break ; 

        case "2" : 

        ans.UpdateBookPrice(newPrice) ; 
        break ; 

        case "3" : 
        ans.UpdateBookStock(newStock) ; 
        break ; 

        case "4" : 
        Console.WriteLine("Thank You ") ; 
        exit = true ; 
        break ; 
      }

    }
  }
}

