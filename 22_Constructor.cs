using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

// Constructor is a Method that has the same name as that of class name
//Constructor do not have return type (even it cannot use void)  so they can not return values.
//Access modifier can be used with Constructor.
// It invoked when objects get created.

// It does not need to call from the main function. It automatically can be run by creating objects.
// we cannot avoid constructors, because we constructor to initialize objects . Thus whenever we creates objects and initialize them by "new <Constructor>" then the constructor automacally get called .
// In other words Constructors allocates the appropriate memory to objects.
//Constructor Initializes the variables of a class.

// Three types of Constructor: 
//i) Default Constructor
//ii) User Defined Constructor
//iii) Parameterized Constructor

//*** Constructor can be overloaded.

namespace Constructor
{
    /*class Program
    {
        public  Program()
        {
            Console.WriteLine("Hello I am Constructor");
            
        }
        static void Main(string[] args)
        {
           // If I don't create the above constructor, the compiler will automatically create a default constructor when 'new' is used.
           //when User creates a Constructor then that constructor will called "User Defined Constructor".

            Program obj = new Program();
            
        }
         
        
    }
    */
     class Car
    {
        string carModel;
        int carYear;
        
        public  Car(string model,int year)//Parameterized Constructor
        {
            carModel=model;
            carYear=year;
            //Thus Constructor helps to initialize the variables of the class.
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Mustang",1969);
            Console.WriteLine("Model:"+myCar.carModel);
            Console.WriteLine("Year:"+myCar.carYear);
            
        }
    }
}
