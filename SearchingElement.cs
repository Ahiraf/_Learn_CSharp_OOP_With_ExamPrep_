using System;

//Search an element in the given array by using foreach loop.

public class Program
{
    public static void Main(string[] args)
    {
      int[] nums = new int[10];
      bool found = false;
      for(int i=0;i<10;i++)
      {
          nums[i]=i;
      }
      int val = int.Parse(Console.ReadLine());
      foreach(int x in nums)
      {
          if(x==val){
              found = true;
              break;
          }
      }
      if(found) Console.WriteLine("Value found!");
      else Console.WriteLine("This value is not here!");
    }
}
