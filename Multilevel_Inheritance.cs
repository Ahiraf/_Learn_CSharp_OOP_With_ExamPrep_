using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{
    class Car
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
   class Ferrari:Car
   {
       public int speed;
       
       public void PrintSpeed()
       {
           Console.WriteLine("Speed : "+speed);
       }
   }
   class Maruti:Ferrari
   {
       float mileage;
       void PrintMileage()
       {
           Console.WriteLine("Mileage : " + mileage);
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
           myCar.speed = 150;
           myCar.PrintSpeed();
           
       }
   }
}












