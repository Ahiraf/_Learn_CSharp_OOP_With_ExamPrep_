using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;



//if we use '+' operator between two int value it will add them up but if we use it between two strings it will concatenate them.
// Two types polymorphism in C# , 
//  i) Compile time polymorphism : Static Polymorphism , and we can achieve it by Method of Overloading 
//  ii) Run time Polymorphism : Dynamic Polymorphism , and we can achieve it by Method of Overriding .

// In Method of overloading We can create multiple methods of same name, in the same class . To do that there are some rules :
//  i) All the Methods should have same name 
// ii) All the Methods should be in same class
//iii) But Methods should have different parameters

namespace Polymorphism
{
    class Program
    {
        void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        void Sum(float a,float b)
        {
              Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Sum(10.5f,20.5f);
        }
            
    }
}


/* To differentiate two Methods of the same name we can do -
i) Different Type of Parameters 
ii) Different Number of Parameters
iii) Different Sequence of Parameters 
*/
