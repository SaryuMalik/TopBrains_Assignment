


// static string CleanseAndInvert(string input){
//      if (string.IsNullOrEmpty(input) || input.Length < 6) return "" ;
//      foreach(char ch in input){
//         if (!char.IsLetter(ch)) {
//             return "" ; 
//         }

//      }

//      input = input.ToLower() ; 
//      List<char>filtered = new List<char>() ; 
//      foreach(char ch in input){
//         if ((int)ch % 2 != 0){
//             filtered.Add(ch) ; 
//         }
//      }

//      filtered.Reverse() ; 

//      for (int i = 0 ; i < filtered.Count ; i++){
//         if (i %2 == 0) {
//             filtered[i] = char.ToUpper(filtered[i]) ; 
//         }
//      }
//      return new string(filtered.ToArray()) ; 
// }

    
//         string result = CleanseAndInvert("abcdef");
//         if (result.Length == 0)
//         {
//             System.Console.WriteLine("invalid");
//         }
//         else
//         {
//             System.Console.WriteLine("Generated String is: "+result);
//         }
    


using System ; 
class Book
{
    public string BookId{get; set;} 
    public string Title{get; set ; }
    public string Author{get; set; }

}

class Member
{
    public string MemberId {get; set;} 
    public string Name {get; set;} 
}

class IssueRecord{
    public string IssueId {get; set;} 
    public Book Book {get; set;} 
    public Member Member{get; set;} 
     
    public void DisplayBook()
    {
        Console.WriteLine(Book.BookId) ; 
    }

    

}

class Program
{
    static void Main(string[] args)
    {
        Book b = new Book
        {
            BookId = "101",
            Title = "C# Basics",
            Author = "John" 
        };
        Member m = new Member
        {
            MemberId = "1",
            Name = "Rahul"
        } ; 

        IssueRecord issue = new IssueRecord
        {
            IssueId = "5001",
            Book = b,     
            Member = m   
        }; 


        issue.DisplayBook() ; 

        

    }
}