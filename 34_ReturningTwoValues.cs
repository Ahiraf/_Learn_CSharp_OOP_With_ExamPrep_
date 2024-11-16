using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//return statement enables a method to return a value to its caller.
//However, a method can return only one value each time it is called.
// But if the user wants to two return two values by one method, then he can use "out" modifier.

namespace UsingOut
{
    class Decompose
    {
        public int GetParts(double n , out double frac)
        {
            int whole = (int) n ;
            frac = n - whole ;
            return whole;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Decompose ob = new Decompose();
           double x = 104.22;
           int i;
           double f;
           i = ob.GetParts(x,out f);
           Console.WriteLine("The number is :" +x);
           Console.WriteLine("Integer portion is :" +i);
           Console.WriteLine("Fractional portion is :" +f);
        }
    }
}

//The GetParts( ) method returns two pieces of information.

//First, the integer portion of n is returned as GetParts( )’s return value.

//Second, the fractional portion of n is passed back to the caller through the out parameter frac.

//As this example shows, by using out, it is possible for one method to return two values.
