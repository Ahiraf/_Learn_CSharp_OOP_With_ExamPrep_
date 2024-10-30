using System;

class A
{
    public int i=0;
    public void Show()
    {
        Console.WriteLine("i in the base class "+i);
    }
}
class B:A
{
   new int i;
  public B(int a,int b)
  {
      base.i=a;
      i=b;
  }
  new public void Show()
  {
      base.Show();
      Console.WriteLine("i in the derived class "+i);
  }
}

public class Program
{
    public static void Main(string[] args)
    {
       B ob = new B(2,3);
       ob.Show();
    }
}
