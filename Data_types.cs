using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   //Assemblies Contain related Namespaces

namespace DataTypes    //Contains related Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 100;   //Like folders, to save data
            int y = x / 2;
            Console.WriteLine(y);
          
            // value = literal
            byte b = 1;
            int i = 100;
            float f = 2.54f; //after assigning  float types literal I have to use f 
            double h = 3.52;
            decimal d = 4.453m; //after assigning decimal types literal I have to use m
            char c = 'm';
            bool l = true;
            Console.WriteLine(b);
            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(h);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(l);
            Console.ReadLine();


        }

    }
}
    /* 2 types of variables : 1) Primitive (Built in )   and   2) Non Primitive (user defined) */
