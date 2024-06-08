using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {

                                               // 1) Selection or Conditional statements :

            int num = 10;
            if (num == 10)
            {
                Console.WriteLine("The number is 10");

            }

            else if (num == 11)
            {
                Console.WriteLine("The number is 11");

            }
            else
            {
                Console.WriteLine("The number is invalid");
            }

                Console.ReadLine();




            //nested if-else :
            int a = 10;
            int b = 20;
            if (a == 10)
            {
                if (b == 20)
                {
                    Console.WriteLine("The value of a is 10 and b is 20");
                }
                else
                {
                    Console.WriteLine("The value of a is 10 and b is not 20");
                }

            }
            else
            {
                Console.WriteLine("The value is invalid");
            }
            Console.ReadLine();


            //Switch statements:
            int number = 10;
            switch (number)
            {
                case 10:
                    Console.WriteLine("The value is 10");
                    break;
                case 20:
                    Console.WriteLine("The value is 20");
                    break;
                case 30:
                    Console.WriteLine("The value is 30");
                    break;
                default:
                    Console.WriteLine("The value is invalid");
                    break;
            }
            Console.ReadLine();



                                                            //2) Iteration or Looping Statem

            
                   //1) for loop
                   //2) while loop
                   //3) do- while loop
                   //4) foreach loop

//For loop;
            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();

            //While Loop:
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();


            //Do while Loop:
             i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
            Console.ReadLine();



                                               //3) Jumping statements :
            
            //1) break statement;
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
                break; // now this loop can print only the first value of j
            }
            Console.ReadLine();


            //2) continue statement;
            for (int j = 0; j < 10; j++)
            {
                continue; //now this loop cannot print anything
                Console.WriteLine(j);
            }
            Console.ReadLine();



            //3) go to statement
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
                goto label;   //now this loop can print only one value of j
            }
            label:
            Console.ReadLine();

        }
    }
}
