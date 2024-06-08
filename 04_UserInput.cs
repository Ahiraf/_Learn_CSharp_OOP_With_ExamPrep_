using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name:"); //to take input in the same line i have to use Console.Write()
            name = Console.ReadLine(); //ReadLine method always returns a string value 
            Console.WriteLine("Username:"+name); //to concatinate name with Username

            Console.Write("Enter your first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello," + firstName+ lastName); //to concatinate first and last name with username

            //If i want to give space between first and last name:
            Console.WriteLine("Hello," + firstName + " " + lastName);
            //another way:
            Console.WriteLine("Hello,{0} {1}", firstName, lastName);
            Console.ReadLine();



            //to take an integer as input
           Console.Write("Enter the first number: ");
            /* int num1 = Console.ReadLine();   // but here , ReadLine method will return a string value so I have to use non compatible type conversion here*/
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition: {0}",num1 + num2);
            Console.ReadLine();

        }
    }
}
