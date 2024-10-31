using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       List<int> numbers = new List<int>{1,5,2,6,43,2};
       numbers.Sort((a,b) => a.CompareTo(b));
       numbers.ForEach(num => Console.WriteLine(num));
       numbers.Sort((a,b) => b.CompareTo(a));
       numbers.ForEach(num => Console.WriteLine(num));
       
    }
}
