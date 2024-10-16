using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

//"List" is same as "Array" used to store multiple values in a single variable .
//Differences between List and Array : 
//i) "Array" is List of items where one knows before hand how many 
// elements are gonna be in list. But in case "List", one does not know before hand how many elements are gonna be in list.
//ii) "Array" is faster but "List" is slower.


//Syntax : List <Datatype> name of list = new list <Datatype> ();
//To use list I have to use the "using System.Collections.Generic" namespace
//How to store elements in a list : by using Add() Method

// The length of a List can be determined by using "ListName.Count()" function


namespace List
{
    public class Program 
    {
        static void Main(string[] args)
        {
            List<string>cars=new List<string>();
            cars.Add("Maruti");
            cars.Add("Ford");
            cars.Add("BMW");
            cars.Add("Ferrari");
           // for(int i=0;i<cars.Count;i++){
           //     Console.WriteLine(cars[i]);
          //  }
          //By foreach Loop : 
          foreach(string car in cars){
              Console.WriteLine(car);
          }
          
        }
    }
}
