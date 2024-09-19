using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   //Assemblies Contain related Namespaces

namespace Type_conversion  //Contains related Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //two types of type conversion : 1) implicit(automatic)  and  2) explicit (user dependent) 
            //Implicit : 1)2 data types must be compatible with each other(means char data type value cannot be assigned in int )  
            //2) We can only assign the value of smaller data types to larger data types
            
            byte b = 10;
            int i = b;
            long l = i;
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.ReadLine();


            //Explicit type conversion:by this I can convert the larger data type into smaller data type which is called type casting
            double d = 60.452;
            int  j = (int)d;
            Console.WriteLine(j); //output = 60
            Console.ReadLine();

            //data loss: When someone try to store data out of range of  that data type
            int m = 300;
            byte n = (byte)m;
            Console.WriteLine(n); //Output = 44; because byte can store up  to 255 number;
            Console.ReadLine();


            //Converting Non compatible data types : 1) by using convert class or  2) using Parse method
            ///Convert class:
            //ToByte()
            //ToInt16()= short
            //ToInt32()=int
            //ToInt64()= double
            string s = "12345";
            int a = Convert.ToInt32(s);      // int a= int.Parse(s)
            Console.WriteLine(a);
            Console.ReadLine();
            //or using parse method
            //byte.Parse
            //short.Parse
            //int.Parse
            //bool.Parse
        }

    }
}
