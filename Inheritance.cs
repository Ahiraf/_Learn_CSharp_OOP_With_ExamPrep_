using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

/*namespace Inheritance
{
    Parent class A
    { 
        //Variables
        //Methods
    }
    Child class B:A(inheritance)
    {
         //Variables
        //Methods
    }
}*/
//What is Inheritance?
//It is a process of inheriting the properties and behaviors of existing class into new class.





/*namespace Inheritance
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
   class Maruti
   {
       
       float mileage;
       void PrintMileage()
       {
           Console.WriteLine("Mileage" + mileage);
       }
       public static void Main(string[] args)
       {
           Maruti myCar = new Maruti();
           // Here, I have created an object of "Maruti" class.
           //But we cannot access model,color,price variable using the myCar object.Because these variables are not in this class . They are in the "Car" class.
           // To do this, we can copy the properties of the "Car" class to the "Maruti" class. 
// However, it will be difficult if the code is long, so I should inherit the properties instead.

       }
   }
} */

// NB: The child class can only access the properties in the parent class that are "Public" or "Protected".If they are private the child class will not be able to inherit them.
//Protected = The code is accessible within the same class, or in a class that is inherited from that class.

/*There are 5 types of Inheritance:

                 // i)Single Inheritance:
            
//In single Inheritance there is only one parent class and one child class.

class A
{
    
}
class B:A
{
    
}
            
            
                 //ii)Multilevel Inheritance
                 
                 
In Multilevel Inheritance, a child class will be inheriting a Parent class and as well as the Child class also act as the Parent class to other class.  



class A
{
    
}
class B:A
{
    
}
class C:B
{
    
}
                 
                 //iii)Hierarchical Inheritance
                 
In Hierarchical Inheritance, there is one Parent class that has more than one Child classes.
 
 class A
 {
     
 }
 class B1:A
 {
     
 }
 class B2:A
 {
     
 }
                 
                 
                 
                     //iv)multiple Inheritance
                     
In Multiple Inheritance, Child class can have more than one Parent class.

 class A1
 {
     
 }
 class A2
 {
     
 }
 class B:A1,A2
 {
     
 }
 *** // It is not possible in C#, but it can be achieved using an "Interface."

                     
                      //v)Hybrid Inheritance
It is mix of two or more of the above types of inheritance. Since C# doesn't support multiple inheritance with classes, the hybrid inheritance is also not possible with classes...

class A
{
    
}
class B1:A
{
    
}
class B2:A
{
    
}
class C:B1,B2
{
    
}
****Not possible in C#.

//So There are 3 types of Inheritance used in C#.
*/


namespace Inheritance
{
    class Car
   {
       public string model;
       public string color;
       public int price;
       
       public void PrintCarInformation()
       {
           Console.WriteLine("Mode: "+model);
           Console.WriteLine("Color: "+color);
           Console.WriteLine("Price: "+price);
       }      
   }
   class Maruti:Car
   {
       float mileage;
       void PrintMileage()
       {
           Console.WriteLine("Mileage: " + mileage);
       }
       public static void Main(string[] args)
       {
           Maruti myCar = new Maruti();
           myCar.model = "Alto";
           myCar.color = "White";
           myCar.price = 20000;
           myCar.mileage = 22.5f;
           myCar.PrintCarInformation();
           myCar.PrintMileage();
           
       }
   }
}












