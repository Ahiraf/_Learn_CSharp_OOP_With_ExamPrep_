using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

// Access Modifiers specify the visibility / accessibility of Class and its Members.
// It also provide restrictions in Class and its Members;
// If we don't use any Accesss Modifier then by default
//every Members of a class will be in Private Access Modifier;
// Be careful when using an access modifier . It should be written in samll letters . 

// Classes cannot be Private or Protected . It is Internal by default which works as same as private.

/* There are total 6 Access Modifier in C#
   1) Public (The code is accessible for all classes )
   2) Private = The code is only accessible within the same class
   3) Protected
   4) Internal (which makes the classes Private and its members public until in the same project.) and 
               (The code is only accessible within its own assembly, but not from another assembly, 
               It means we can use all classes and its members publicly until we are in the same project or same file)
   5) Protected Internal
   6) Private Protected
*/
namespace Access_Modifiers
{
    class Car
   {
       private string model;
       private string color;
       private int price;
       
       void PrintCarInformation()
       {
           Console.WriteLine("Mode:"+model);
           Console.WriteLine("Color:"+color);
           Console.WriteLine("Price:"+price);
           Console.ReadLine();
       }       
   } 
   
   class Program
   {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model ; // Now as model is private varible of a private class , I cannot call it in another class    
        }  
   } 

 */


   /* So,
    class Car
    {
       string model;
       string color;
       int price;
       
       void PrintCarInformation()
       {
           Console.WriteLine("Mode:"+model);
           Console.WriteLine("Color:"+color);
           Console.WriteLine("Price:"+price);
           Console.ReadLine();
       }
       static void Main(string[] args){
            Car myCar = new Car();
            myCar.model = "Ferrari"; //Now I can call it because the main method is in the same class.
            myCar.color = "Black";
            myCar.price = 30000000;
            myCar.PrintCarInformation();
        }
       
    
   }  */
   //Or, If I use the Main Method in the Program class , then I should use public Access Modifier in the Car Class.*/
  
  internal class Car //now the Car class is private
   {
       internal string model; // this variables can be used in Program class also if The class is in Public not in internal.
       internal string color;
       internal int price;
       
       internal void PrintCarInformation()//This method can also use like a public method in the same assembly or file
       {
           Console.WriteLine("Mode:"+model);
           Console.WriteLine("Color:"+color);
           Console.WriteLine("Price:"+price);
           Console.ReadLine();
       }
       static void Main(string[] args)
       {
            Car myCar = new Car();
            myCar.model = "Ferrari"; //Now I can call it because the main method is in the same class.
            myCar.color = "Black";
            myCar.price = 30000000;
            myCar.PrintCarInformation();
        }
   }  
}
