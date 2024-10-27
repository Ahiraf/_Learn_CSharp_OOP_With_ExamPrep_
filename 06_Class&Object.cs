using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Calculator  //Class doesn't occupy memory. It contains "Attributes" and "Methods".
    {
        //Attributes – member variables, used to store data about the object.
        //Methods – member functions, used to perform specific task for that object.
        
        int num1;
        int num2;
        int result;
        void Add()
        {
            result=num1+num2;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    void Subtract()
    {
        result=num1-num2;
        Console.WriteLine(result);
            Console.ReadLine();
    }
        static void Main(string[] args)
        {
            //Instantiation – to use a class, an object for that class must be created.It is called "Instantiation".
            Calculator obj = new Calculator(); //Objects occupy memory 
            obj.num1 = 20;
            obj.num2 = 30;
            obj.Add();
            obj.Subtract();
            Calculator obj2 = new Calculator();
            obj2.num1 = 40;
            obj2.num2 = 30;
            obj2.Add();
            obj2.Subtract();

        }
    }
}

