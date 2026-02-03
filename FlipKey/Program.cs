


static string CleanseAndInvert(string input){
     if (string.IsNullOrEmpty(input) || input.Length < 6) return "" ;
     foreach(char ch in input){
        if (!char.IsLetter(ch)) {
            return "" ; 
        }

     }

     input = input.ToLower() ; 
     List<char>filtered = new List<char>() ; 
     foreach(char ch in input){
        if ((int)ch % 2 != 0){
            filtered.Add(ch) ; 
        }
     }

     filtered.Reverse() ; 

     for (int i = 0 ; i < filtered.Count ; i++){
        if (i %2 == 0) {
            filtered[i] = char.ToUpper(filtered[i]) ; 
        }
     }
     return new string(filtered.ToArray()) ; 
}

    
        string result = CleanseAndInvert("abcdef");
        if (result.Length == 0)
        {
            System.Console.WriteLine("invalid");
        }
        else
        {
            System.Console.WriteLine("Generated String is: "+result);
        }
    

