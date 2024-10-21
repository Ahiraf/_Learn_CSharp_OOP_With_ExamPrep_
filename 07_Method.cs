using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

// Method is a group of related satements. 
// We can organize code in methods and can give name to call it by its name as many time as we want .

// We can call a non-static mathod in a non-static method , If they both are in the same class .
//But we cannot call a non-static method in a static method(like Main Method) . 
//To call it we should creat object first . Or we should make all the non-static method static.



//             public/          int/ float/                                 
//             private          string/void                                int a,int b
// Syntax : <Access Modifier> <Return Type> <Method Name or Identifier> <Parameter list>
//           {
                     // Body of Method 
//            }

// 4 types of Methods : 

// i) Method with no argument and no return value. 
//ii) Method with no argument but return value.
//iii) Method with argument but no return value.
//iv) Method with argument and return value.

 
namespace Method
{
    public class Calculator 
    {
        int num1=10;
        int num2=20;
        int result;
        void Sum()
        {
            result=num1+num2;
            Display();
        }
        void Subtract()
        {
            result=num1-num2;
            Display();
        }
        void Division()
        {
            result=num1/num2;
            Display();
            
        }
        void Multiplication()
        {
            result=num1*num2;
            Display();
            
        }
        void Display()
        {
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Calculator obj=new Calculator();
            obj.Sum(); // Will show 30 as output 
        
        
        }
    }
}
