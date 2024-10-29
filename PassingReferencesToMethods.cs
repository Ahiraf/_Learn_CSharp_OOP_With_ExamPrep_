using System;

namespace PssingReferencesToMethods
{
  public class Myclass
  {
      public int alpha;
      public int beta;
      public  Myclass(int i,int j)
      {
          alpha = i;
          beta = j;
      }
      public bool SameAs(Myclass ob)
      {
          if(ob.alpha == alpha && ob.beta == beta)
          {
              return true;
          }
          return false;
      }
      public void Copy(Myclass ob)
      {
         ob.alpha = alpha;
         ob.beta = beta;
      }
  }

  public class Program
  {
      public static void Main(string[] args)
      {
          Myclass obj1 = new Myclass(4,5);
          Myclass obj2 = new Myclass(9,10);
          Console.WriteLine("The value of Obj1 :"+obj1.alpha+" "+obj1.beta);
          Console.WriteLine("The value of Obj2 :"+obj2.alpha+" "+obj2.beta);
          Console.WriteLine();
        
          if(obj1.SameAs(obj2))
          {
              Console.WriteLine("Obj1 and Obj2 are same");
          }
          else
          {
              Console.WriteLine("Obj1 and Obj2 are not same");
          }
          obj1.Copy(obj2);
          if(obj1.SameAs(obj2))
          {
                Console.WriteLine("Obj1 and Obj2 are same");
          }
          else
          {
                Console.WriteLine("Obj1 and Obj2 are not same");
          }
      }  
  }
}
