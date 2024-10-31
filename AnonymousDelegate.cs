using System;

public delegate  void Mydelegate(int a,int b);

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Mydelegate Add = delegate(int a,int b)
       {
           Console.WriteLine(a+b);
       };
       Add(2,3);
    }
}
