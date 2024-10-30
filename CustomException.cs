using System;
using System.Exception;

public class Program
{
    public static void Main(string[] args)
    {
       int age = int.Parse(Console.ReadLine());
       void InvalidAgeException(int i)
       {
           if(i<18)
           {
               throw new ArgumentException("this age in not valid.");
           }
       }
       try
       {
           InvalidAgeException(age);
       }
       catch(ArgumentException ex)
       {
           Console.WriteLine("Error : "+ex.Message);
           
       }
    }
}
