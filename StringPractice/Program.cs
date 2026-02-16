//Counting Letters Digits and Special Characters 
// using System ; 
// class Program
// {
//   static void Main(string[] args)
//   {
//     string s = "Ab@12#X";
//     int CountLetter = 0 ; 
//     int CountDigits = 0 ; 
//     int CountSpecialCharacters = 0 ; 

//     foreach(char ch in s)
//     {
//       if (Char.IsLetter(ch)) CountLetter++ ;
//       else if (Char.IsDigit(ch))CountDigits++ ; 
//       else if (Char.IsSymbol(ch) || Char.IsPunctuation(ch)) CountSpecialCharacters++ ; 
//     }

//     Console.WriteLine($"Letters : {CountLetter} Digits : {CountDigits} SpcialCharacters : {CountSpecialCharacters}") ; 

//   }
// }

//To check if the string contains other letters or not 
// using System ;
// class Program
// {
//   static void Main(string[] args)
//   {
//     string s = "Hello123@";
//     bool ans = true  ;

//     foreach(char ch in s)
//     {
//       if (!Char.IsLetter(ch))
//       {
//         Console.WriteLine("Contains Other Characters") ;
//         ans = false ; 
//         break ; 

//       }
//     }

//    if (ans)
//    Console.WriteLine("Only Letters") ; 

//   }
// }

//Checking For Valid Password or Invalid Password 
// using System ; 
// class Program
// {
//   static void Main(string[] args)
//   {
//     string pwd = "Test@123";
//     bool value1 = false ; 
//     bool value2 = false ; 
//     bool value3 = false ; 
//     foreach(char ch in pwd)
//     {
//       if (Char.IsUpper(ch)) value1 = true ;
//       if (Char.IsDigit(ch)) value2 = true  ; 
//       if (Char.IsSymbol(ch)|| Char.IsPunctuation(ch)) value3 = true ; 
//     }

//     if (value1 && value2 && value3)
//     {
//       Console.WriteLine("Valid Password") ; 
//     }
//     else
//     {
//       Console.WriteLine("Invalid Password") ; 
//     }



//   }
// }

// Use oF Trim 
// using System ;
// class Program
// {
//   static void Main(string[] args)
//   {
//     string s = "  Hello World  ";
//     string new1 = s.Trim().ToUpper() ; 
//     Console.WriteLine(new1) ; 


//   }
// }

// Checking of Palindrome 
// using System ;

// class Program
// {
//   static void Main(string[] args)
//   {
//     string s = "madam";
//     char[] arr = s.ToCharArray() ; 
//     for (int i = 0 ; i < arr.Length/2 ; i++)
//     {
//      (arr[i] , arr[arr.Length - i - 1]) = (arr[arr.Length - i - 1] , arr[i]) ; 
//     }

//     string reversed = new string(arr) ; 

//     bool ans = true ; 
//     for (int i = 0 ; i < s.Length ; i++)
//     {
//       if (s[i] != reversed[i])
//       {
//         ans = false ; 
//         break ; 
//       }
//     }

//     if (ans) Console.WriteLine("Palindrome") ; 
//     else 
//     Console.WriteLine("Not Palindrome") ; 


//   }
// }

//How many words in a sentence 
// using System ;
// class Program
// {
//   static  void Main(string[] args)
//   {
//     string s = "Hello world from CSharp";
//     string[] words = s.Split(" " , StringSplitOptions.RemoveEmptyEntries) ;

//     Console.WriteLine(words.Length) ; 



//   }

// }


//FInd Longest Word 

// using System ; 
// class Program
// {
//   static void Main(string[] args)
//   {
//     string s = "CSharp is very powerful language";

//     string[] arr = s.Split(" " , StringSplitOptions.RemoveEmptyEntries) ;
//     string max = arr[0] ;

//     for (int i = 1 ; i < arr.Length ; i++)
//     {
//        if(arr[i].Length > max.Length)
//       {
//         max = arr[i] ; 
//       }
//     }

//     Console.WriteLine(max) ; 

//   }
// }


//Removes words in a sentence 

// using System ;
// class Program
// {
//   static void Main(string[] args)
//   {
//     string s = "Hello world from CSharp";
//     string[] arr = s.Split(" " , StringSplitOptions.RemoveEmptyEntries) ; 

//     for (int i = 0 ; i < arr.Length/2 ; i++)
//     {
//        (arr[i] , arr[arr.Length - i - 1]) = (arr[arr.Length - i - 1] , arr[i]) ; 
//     }

//     string ans = string.Join(" " , arr) ;
//     Console.WriteLine(ans) ; 


//   }
// }


//Count the frequency 


// using System ; 
// class Program
// {
//   static void Main(string[] args)
//   {
//     string s = "mississippi";
//     int[] arr = new int[] ; 
//     foreach (char ch in s)
//     {

//     }


//   }

// }


// Reversing the wrod of the sentence 
// using System ;
// class Program
// {
//   static void Main(string[] args)
//   {
//     string s2 = "Hello World" ;
//     string[] arr = s2.Split(" " , StringSplitOptions.RemoveEmptyEntries) ;
//     List<string> arr2 = new List<string>(); 

//     foreach(string s1 in arr)
//     {

//       char[] s = s1.ToCharArray() ; 
//       for (int i = 0 ; i < s.Length/2 ; i++)
//       {
//          (s[i] , s[s.Length - i - 1]) = (s[s.Length - i - 1] , s[i]) ; 
//       }

//       string s3 = new string (s) ; 
//       arr2.Add(s3) ; 

//     }

//     string final = string.Join(" " , arr2) ;
//     Console.WriteLine(final) ;  

//   }
// }



// Use of Linq 
// using System ;
// using System.Collections.Generic ;
// using System.Linq ;
// class Program
// {
//   static void Main(string[] args)
//   {
//     List<int>num = new List<int>() ;
//     num.Add(5) ;
//     num.Add(10) ;
//     num.Add(15) ;
//     num.Add(20) ;

//     foreach (int n in num)
//     {
//       if (n % 2 == 0)
//       {
//         Console.WriteLine(n) ;
//       }
//     }


//   }

// }

// Printing the strings from the List where String starts with Letter R 
// using System ;
// using System.Collections.Generic ; 

// class Program
// {
//   static void Main(string[] args)
//   {
//     List<string> str = new List<string>() ; 

//     str.Add("Ram") ;
//     str.Add("Shyam") ; 
//     str.Add("Amit") ; 
//     str.Add("Ravi") ; 

//     foreach (string s in str)
//     {
//       if (s[0] == 'R')
//       {
//         Console.WriteLine(s) ; 
//       }
//     }
//   }
// }


// Starting with Dictionaries 
// using System ;
// using System.Collections.Generic ;
// class Program
// {
//   static void Main(string[] args)
//   {
//     Dictionary<int , string>Fruits = new Dictionary<int , string>() ;

//     Fruits.Add(1 , "Apple") ;
//     Fruits.Add(2 , "Banana") ;
//     Fruits.Add(3 , "Mango") ; 

//     foreach (var item in Fruits)
//     {

//       Console.WriteLine(item.Value) ; 
//     }

//   }
// }


// using System ;
// using System.Collections.Generic ;
// class Program
// {
//   static void Main(string[] args){
//     HashSet <int> Numbers = new HashSet<int>() ; //Add: 1, 2, 3, 2, 1, 4
//     Numbers.Add(1) ; 
//     Numbers.Add(2) ; 
//     Numbers.Add(3) ; 
//     Numbers.Add(2) ;
//     Numbers.Add(1);
//     Numbers.Add(4) ; 

//     foreach(int a in Numbers)
//     {
//       Console.WriteLine(a) ; 
//     }
//   }
// }

// Printing the Highest Value 
// using System ;
// using System.Collections.Generic ;
// class Program
// {
//   static void Main(string[] args)
//   {
//     Dictionary<int , int> MarksStudent = new Dictionary<int , int>() ; 
//     List<int>store = new List<int>() ; 
//     MarksStudent.Add(1 , 85);
//     MarksStudent.Add(2 , 72) ; 
//     MarksStudent.Add(3 , 90) ; 
//     MarksStudent.Add(4 , 72) ;
//     int HighestValue = -1 ; 
//     foreach(var ans in MarksStudent)
//     {
//        if (ans.Value > HighestValue)
//       {
//         HighestValue =ans.Value ; 
//       }
//        Console.WriteLine(  $"{ans.Key} -> {ans.Value}") ; 
//     }
//     Console.WriteLine(HighestValue) ; 



//   }
// }

// Taking out the duplicates and unique values fromt the Dictionary 
// using System ;
// using System.Collections.Generic ; 
// class Program
// {
//   static void Main(string[] args)
//   {
//     Dictionary<string, int> data = new Dictionary<string, int>()
//     {
//        {"A", 10},
//        {"B", 20},
//        {"C", 10},
//        {"D", 30},
//        {"E", 20}
//     };
//     HashSet<int>Seen = new HashSet<int>() ; 
//     HashSet<int>Duplicates = new HashSet<int>() ; 

//     foreach (var ans in data)
//     {
//       if (!Seen.Add(ans.Value))
//       {
//         Duplicates.Add(ans.Value) ; 
//       }
//     }

//     foreach(int Value in Duplicates)
//     {
//       Console.WriteLine(Value) ; 
//     }

//     foreach(var ans in data)
//     {
//       if (!Duplicates.Contains(ans.Value))
//       {
//         Console.WriteLine(ans.Value) ; 
//       }
//     }




//   }
// }

// Error Solving 
// using System ;
// using System.Collections.Generic ;
// class Program
// {
//   static void Main(string[] args)
//   {
//     List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6 };

//     foreach(int n in nums)
//     {
//       if (n % 2 == 0)
//       {
//         nums.Remove(n) ; 
//       }
//     }

//     Console.WriteLine(nums) ; 

//   }
// }

// Frequency of Each name 
// using System;
// using System.Collections.Generic;

// class Program
// {
//   static void Main(string[] args){
//     List<string> names = new List<string>()
//     {
//       "Ram", "Shyam", "Ram", "Amit", "Shyam", "Ram"
//     };
//     Dictionary<string , int> frequency = new Dictionary<string , int >() ; 

//     foreach(string value in names)
//     {
//         if (frequency.ContainsKey(value)){
//          frequency[value]++ ; 
//         }
//         else
//       {
//         frequency[value] = 1 ; 
//       }
//     }

//     foreach(var ans in frequency)
//     {
//       Console.WriteLine($"{ans.Key} -> {ans.Value}") ; 
//     }
//   }

// }

// Frequency of the numbers and Printing the numbers whose frequency is more than 1 . 
// using System ;
// using System.Collections.Generic ;
// class Program
// {
//   static void Main(string[] args)
//   {
//     List<int> nums = new List<int>()
// {
//     10, 20, 10, 30, 20, 40, 50, 40
// };
//     Dictionary<int , int> frequency = new Dictionary<int , int>() ; 

//     foreach(int value in nums)
//     {
//       if (frequency.ContainsKey(value))
//       {
//           frequency[value]++ ; 
//       }
//       else
//       {
//         frequency[value] = 1 ; 
//       }
//     }

//     foreach(var ans in frequency)
//     {
//       if (ans.Value > 1)
//       {
//         Console.WriteLine($"{ans.Key} -> {ans.Value}") ; 
//       }
//     }

//   }
// }


//Use of Built-In  Deligate - Action
// using System ;
// class Program
// {
//   static void Main(string[] args)
//   {
//     Action<int>Print = a => Console.WriteLine(a) ; 
//     Print(5) ; 
//   }
// }

//use of Built In Deligate - Func 
// using System ;

// class Program
// {
//   static void Main(string[] args)
//   {
//     Func<int , int, int>product = (a , b) => (a*b) ;
//     Console.WriteLine(product(5 , 6)) ; 
//   }
// }


// Use of Event for payment success message 

// using System ;
// delegate void paymentHandle() ;

// class Payment
// {
//    public event paymentHandle? PaymentDone ; 
//    public void CompletePayment()
//   {
//     Console.WriteLine("-------Payment processing--------") ;
//     PaymentDone?.Invoke() ; 
//   }
// }

// class Program
//   {

//     static void PaymentMessage()
//     {
//       Console.WriteLine("Payment Done") ; 
//     }
//     static void Main()
//     {
//         Payment p = new Payment() ; 
//         p.PaymentDone += PaymentMessage ; 
      
//         p.CompletePayment() ; 
//     }
//   }



