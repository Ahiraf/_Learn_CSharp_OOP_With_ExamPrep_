using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace Method
{
    public class Program
    {
        public int Findmax(int num1,int num2)
        {
            int result;
            if(num1>num2)result=num1;
            else result=num2;
            return result;
        }
        
        public static void Main(string[] args)
        {
            Program max = new Program();
            int a,b;
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            int ans=max.Findmax(a,b);
            Console.WriteLine("The maximum number is : "+ans);
            Console.ReadLine();
        
        }
    }
}
