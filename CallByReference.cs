using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
=>In this method, a reference to an argument (not the value of the argument) is
passed to the parameter.

=>Inside the subroutine, this reference is used to access the actual argument
specified in the call.

=>This means that changes made to the parameter will affect the argument used to
call the subroutine.
*/

namespace CallByReference
{
    class Test
    {
        public int a,b;
        public  Test(int i,int j)
        {
            a=i;
            b=j;
        }
        public void Change(Test ob)
        {
            ob.a+=ob.b;
            ob.b++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test(10,5);
            Console.WriteLine("Before Call : a="+obj.a+" b="+obj.b);
            obj.Change(obj);
            Console.WriteLine("After  Call : a="+obj.a+" b="+obj.b);       
        }
    }
}
