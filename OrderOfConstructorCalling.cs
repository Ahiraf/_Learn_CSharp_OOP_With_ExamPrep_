using System;

class A
{
    public A()
    {
        Console.WriteLine("Constructing A");
    }
}
class B:A
{
    public B()
    {
        Console.WriteLine("Constructing B");
    }
}
class C:B
{
    public C()
    {
        Console.WriteLine("Constructing C");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
       C ob = new C();
       
    }
}
