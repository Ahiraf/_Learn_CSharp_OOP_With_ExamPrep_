using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatements
{
    class Calculator  //Class doesn't occupy memory
    {
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

