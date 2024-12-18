using System;

/*
A delegate in C# is like a placeholder for a method.One can use a delegate to call different methods dynamically at runtime, 
without knowing which method will be called in advance. It is especially useful when the user wants to pass methods as arguments to 
other methods.
It can be thought like, having a remote control (the delegate) that can be programmed to control different devices (methods) 
that all follow the same rules (signature of the method).

=>A delegate specifies the signature of the methods it can call (e.g., the number and types of parameters, and the return type).
=>User can assign different methods to a delegate, as long as those methods have the same signature.
=>A delegate can point to multiple methods and can invoke them all (this is called multicast delegate).

*/

 public delegate int MyDelegate(int a ,int b);
 
 class Calculator
 {
     public int Add(int a,int b)
     {
         return a+b;
     }
     public int Subtract(int a, int b)
     {
         return a-b;
     }
 }

public class Program
{
    public static void Main(string[] args)
    {
        Calculator Mycalculator = new Calculator();
        MyDelegate del = new MyDelegate(Mycalculator.Add);
        int result = del(5,6);
        Console.WriteLine("The result is : "+result);
        del = Mycalculator.Subtract;
        result = del(10,22);
        Console.WriteLine("The result is : "+result);
    }
}
