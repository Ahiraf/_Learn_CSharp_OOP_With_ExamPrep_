using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callByReference
{
    class ValueSwap
    {
        public void swap(ref int a , ref int b)
        {
            int temp = a;
            a=b;
            b=temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ValueSwap myValue = new ValueSwap();
            int a = 10 , b = 5;
            Console.WriteLine("Before Swap : ");
            Console.WriteLine("a="+a+"  b="+b);
            myValue.swap(ref a,ref b);
            Console.WriteLine("After  Swap : ");
            Console.WriteLine("a="+a+"  b="+b);
        }
    }
}
