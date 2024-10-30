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
   new int i;  //This i hides the i in A
  public B(int a,int b)
  {
      base.i = a; //This uncovers the i in A
      i = b;
  }
  new public void Show() // This Show() hides the Show() in A
  {
      base.Show(); //This uncovers the Show() in A.
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
