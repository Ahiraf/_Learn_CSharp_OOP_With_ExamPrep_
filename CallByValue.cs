using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
=>This method copies the value of an argument into the formal parameter of the
subroutine.

=>Therefore, changes made to the parameter of the subroutine have no effect on the
argument used in the call.
*/

namespace CallByValue
{
    class Test
    {
        public void NoChange(int i,int j)
        {
            i+=j;
            j++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            int a=10 , b=5;
            Console.WriteLine("Before Call : a="+a+" b="+b);
            obj.NoChange(a,b);
            Console.WriteLine("After  Call : a="+a+" b="+b);
            
        }
    }
}
