using System;
using System.IO;

public class NegativeNumberException : Exception
{
    publice NegativeNumberException(string message) : base(message){ }
}
public class Calculator
{
   public int Division(int a,int b)
   {
       int result = a/b;
       if(b==0){
           throw new DivideByZeroException("Cannot divide by zero");
       }
       if(result < 0)
       {
           throw new NegativeNumberException("The ans cannot be negative");
       }
       return result;
   }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
      Calculator calc = new Calculator();
      string filepath = "input.txt";
      try
      {
          using (StreamReader reader = new StreamReader(filepath))
          {
              string line ;
              while((line = reader.ReadLine()) != null)
              {
                  try
                  {
                      string[] parts = line.Split(' ');
                      int a = int.Parse(parts[0]);
                      int b = int.Parse(parts[1]);
                      Console.WriteLine("The result is : "+clac.Division(a,b);
                  }
                  catch(DivideByZeroException ex)
                  {
                      Console.WriteLine("Error : "+ex.Message);
                  }
                  catch(NegativeNumberException ex)
                  {
                      Console.WriteLine("Error : "+ex.Message);
                  }
                  catch(FormatException ex)
                  {
                      Console.WriteLine("The format is not accurate "+ex.Message);
                  }
              }
          }
      }
      catch(FileNotFoundException)
      {
          Console.WriteLine("This File can not be founded");
      }
      catch(Exception ex)
      {
          Console.WriteLine("Error : "+ex.Messsage);
      }
      finally
     {
         Console.WriteLine("Finished Processing the file");
     }
    }
}
