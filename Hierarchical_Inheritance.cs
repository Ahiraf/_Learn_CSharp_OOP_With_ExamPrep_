using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance
{
    class Car    //Parent class
   {
       public string model;
       public string color;
       public int price;
       
       public void PrintCarInformation()
       {
           Console.WriteLine("Mode : "+model);
           Console.WriteLine("Color : "+color);
           Console.WriteLine("Price : "+price);
       }      
   }
   class Ferrari:Car     //Child class
   {
       public int speed;
       
       public void PrintSpeed()
       {
           Console.WriteLine("Speed : "+speed);
       }
   }
   class Maruti:Car  //Child class
   {
       float mileage;
       void PrintMileage()
       {
           Console.WriteLine("Mileage : " + mileage);
       }
       public static void Main(string[] args)
       {
           Maruti myCar1 = new Maruti();
           Ferrari myCar2 = new Ferrari();
           myCar1.model = "Alto";
           myCar1.color = "White";
           myCar1.price = 20000;
           myCar1.mileage = 22.5f;
           myCar1.PrintCarInformation();
           myCar1.PrintMileage();
           myCar2.model = "Ferrari";
           myCar2.color = "Black";
           myCar2.price = 30000;
           myCar2.PrintCarInformation();
           myCar2.speed = 120;
           myCar2.PrintSpeed();
           
       }
   }
}












