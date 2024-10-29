using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

/* a method is created, it is usually known in advance the number of arguments
Want to create a method that can be passed an arbitrary number of arguments.
For example, consider a method that finds the smallest of a set of values.
Passing an arbitrary number of parameters done by creating a params parameter.
*/
namespace Param
{
    class MyClass
    {
        public void Show(string msg , params int[] nums)
        {
            Console.WriteLine(msg+" : ");
            foreach(int i in nums)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            ob.Show("Here are some numbers",1,2,3,4,5);
            ob.Show("Here are some more",6,7,8,9,10);
            
        }

    }
}
