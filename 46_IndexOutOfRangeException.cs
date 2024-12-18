using System;
using System.Exception;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {1,3,2,5};
      try
      {
          int index = int.Parse(Console.ReadLine());
           int value = arr[index];
              Console.WriteLine("Value at index "+index+" is "+arr[index] );
              
          void InvalidIndexException(int i)
          {
              if(i<0)
              {
                  throw new ArgumentException("The index cannot be negative.");
              }
          }
          try
          {
              InvalidIndexException(index);
          }
          catch(ArgumentException ex)
          {
              Console.WriteLine("Error : "+ex.Message);
          }
      }
      catch(IndexOutOfRangeException ex)
      {
          Console.WriteLine("The index is out of range "+ex.Message);
      }
    }
}
