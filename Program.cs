using System;
using System.Linq;

class Program
{

    static Boolean IsUpperCase (string s){
        return s.All(char.IsUpper); // All returns a boolean after cheching a certain condition on all elements
    }
    static Boolean IsLowerCase (string s){
        return s.All(char.IsLower); // All returns a boolean after cheching a certain condition on all elements
    }
    
    static Boolean IsPasswordComplex( string s){
        return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
    } 

    static string NormalizeString (String input){
        return input.ToLower().Trim().Replace("," ," ");

    }  

    //least complex and least efficient method to search: Contain() method
    //if you need iterate through the whole string :
    static void ParseContens(string s){
        Console.WriteLine("the first Option is: ");
        foreach(char c in s){
              Console.WriteLine(c);
        }
        Console.WriteLine("the second Option is: ");
        for (int i = 0 ; i <s.Length ; i++){
            char c = s[i];
            Console.WriteLine(c);
        }
    
    }
    static Boolean IsAtEvenIndex(String s , char item){
        //check the string first 
        if (String.IsNullOrEmpty(s)){
            return false;
        }

        //if Not Empty or Null
        for (int i = 0 ; i <s.Length / 2 +1 ; i= i+2){
          if(s[i]== item){
            return true;
          }
        }
        return false;
    }


    static int FindMax(int a, int b, int c)
    {
        int max = a;

        if (b > max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }

        return max;
    }
 
    static void Main(string[] args)
    {
        // Console.WriteLine("Maximum value is: " + FindMax(2, 5, 9));
        // Console.WriteLine("the result is " + IsUpperCase("AAA"));
        // Console.WriteLine("the result is " + IsLowerCase("AAA"));
       // Console.WriteLine("the password complexity is " + IsPasswordComplex("aaa24"));
       // Console.WriteLine("the normalized string is: " + NormalizeString("Hello Niloo, Are you ok?       "));

         //least complex and least efficient method to search: Contain() method
        // Console.WriteLine("the normalized string is: ".ToLower().Contains("al"));
        //  ParseContens("");

        String input = " hello ";
          Console.WriteLine(IsAtEvenIndex(input, 'e'));
    }
    }

