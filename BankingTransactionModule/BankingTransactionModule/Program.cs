using System ;
namespace BankingApplication
{
  public class Account
  {
    public  string AccountNumber{get; set;} 
    public decimal Balance {get; set; }

    public decimal Deposit(decimal amount)
    {
      try
      {
         if (amount > 0)
        {
          Balance += amount ; 
        }
        else
        {
          throw new ArgumentException("Deposit Amount must be positive") ; 
        }
      }
      catch(ArgumentException ex)
      {
         Console.WriteLine(ex.Message) ; 
      }
      return Balance ;
    }

    public decimal Withdraw(decimal amount)
    {
      try
      {
        if (amount <= 0 )
        {
          throw new ArgumentException("Withdrawl amount must be positive ") ; 
        }
        else if (amount  > Balance)
        {
          throw new InvalidOperationException("Insufficient Funds ") ;  
        }
        else
        {
          Balance -= amount ; 
        }
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message) ; 
      }
      catch(InvalidOperationException ex)
      {
        Console.WriteLine(ex.Message) ; 
      }
      return Balance ; 
    }

  }
  public class Program
  {
    public static void Main(string[] args)
    {
       Account userAccount = new Account() ; 
       Console.WriteLine("1: Deposit") ; 
       Console.WriteLine("2: Withdraw") ;
       Console.WriteLine("Enter the Choice ") ; 
       if (! int.TryParse(Console.ReadLine() , out int choice))
      {
        Console.WriteLine("Invalid Choice,Please Enter 1 or 2 ") ; 
        return ; 
      }
      Console.WriteLine("Enter the Account Number ") ; 
      userAccount.AccountNumber = Console.ReadLine() ; 

      Console.WriteLine("Enter the Initial Balance ") ; 
      userAccount.Balance = ReadDecimalInput() ; 

      if (choice == 1)
      {
        Console.WriteLine("Enter the amount to deposit : ") ; 
        decimal amount = ReadDecimalInput() ; 
        Console.WriteLine("Final Balance " + userAccount.Deposit(amount)) ; 
      }

     if (choice == 2)
      {
        Console.WriteLine("Enter the amount to withdraw") ; 
        decimal amount = ReadDecimalInput() ; 
        Console.WriteLine("Final Balance " + userAccount.Withdraw(amount)) ;
      } 
    }
    
    
       private static decimal ReadDecimalInput()
        {
            decimal result;
            while (!decimal.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric amount:");
            }
            return result;
        }
    }
  }

