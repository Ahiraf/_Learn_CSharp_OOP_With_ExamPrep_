using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

// A program to find Factorial using "Recursion".

namespace Recursion
{ 
    class Program
    {
        int num=5;
        int result=1;
        
        int Factorial()
        {
            if(num==0)
            {
                return 1;//Factorial of 0 = 1.
            }
            result = result*num;
            num--;
            Factorial();
            return result;
            
        }
        
        static void Main(string[] args)
        {
            Program obj = new Program();
            int factorial = obj.Factorial();
            Console.WriteLine("Factorial is : "+factorial);
            
        }
    }
}
