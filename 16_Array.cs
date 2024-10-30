using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


//Array is a collection of similar data type of the same type/list of elements of same type.

// Syntax : data type [] name of arrayVariable;
// Length of an array : ArrayName.Length();
// Two type of Arrays : i) Single Dimensional Array
//                     ii) Multi Dimensional Array

namespace Array
{
    public class Program 
    {
        static void Main(string[] args)
        {
           /* string car1 = "Maruti";
            string car2 = "Ford";
            string car3 = "BMW";
            string car4 = "Ferrari";*/
            //Instead of using string every time I can create a string type array that will store all the cars.
          //  string[] cars = {"Maruti","Ford","BMW","Ferrari"};
            
            //I can also create array with a given size like this: 
              string[] cars = new string[4] {"Maruti","Ford","BMW","Ferrari"};
              
              //How to access every elements of an array : 
              Console.WriteLine(cars[3]);
              for(int i=0;i<cars.Length;i++)
              {
                    Console.WriteLine(cars[i]);
                  
              }
              //Using foreach loop : 
              foreach(string car in cars)
              {
                  Console.WriteLine(car);
              }
        }
    }
}
