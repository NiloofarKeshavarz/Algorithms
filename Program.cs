using System;

class Program
{
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
        Console.WriteLine("Maximum value is: " + FindMax(2, 5, 9));
    }
}
