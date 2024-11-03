using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace ConstructorOverloading
{
    
     class Car
    {
        string carModel;
        int carYear;
        
        public  Car(string model,int year)
        {
            carModel=model;
            carYear=year;
        }
        public  Car(int year,string model)
        {
            carModel=model;
            carYear=year;
        }
        static void Main(string[] args)
        {
            Car myCar = new Car(1969,"Mustang");
            Console.WriteLine("Model:"+myCar.carModel);
            Console.WriteLine("Year:"+myCar.carYear);
            
        }
    }
}
