using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
