using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

// Method is a group of related satements. 
// We can organize code in methods and can give name to call it by its name as many time as I want .

// We can call a non-static mathod in a non-static method , If they both are in the same class . But we cannot call a non-static method in a static method . To call it we should creat object first . Or we should make the non-static method static/


namespace Method
{
    class Calculator 
    {
        int num1;
        int num2;
        int result;
        void Sum()
        {
            result=num1+num2;
        }
        void Subtract()
        {
            result=num1-num2;
        }
        void Division()
        {
            result=num1/num2;
            
        }
        void Multiplication()
        {
            result=num1*num2;
            
        }
        void Display()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    public static void Main(string[] args)
    {
        Calculator obj=new Calculator;
        
        
    }
}
