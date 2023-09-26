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
        Console.WriteLine("the password complexity is " + IsPasswordComplex("aaa24"));
    }
}
