using System ;
using System.Collections.Generic ; 
using System.Linq ; 

class InsufficientBalanceException : Exception
{
  public 	InsufficientBalanceException (string msg) : base(msg ){ }

}
class MinimumBalanceException : Exception
{
  public MinimumBalanceException (string msg) : base(msg) { } 
}
class InvalidTransactionException
{
  public 	InvalidTransactionException(string msg) : base(msg) { }
} 
abstract class BankAccount
{
   public string AccNumber {get;set;} 
   public string Name {get;set;}  
   public int Balance {get; set; }

   public void Deposit()
  {
    
  } 
   public void Withdraw() { } 
   public abstract void CalculateInterest () ;
}

public class SavingsAccount () : BankAccount 
{
  
}

public class CurrentAccount() : BankAccount
{
  
}

public class LoanAccount() : BankAccount
{
  
}

