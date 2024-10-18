using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


/* Method()
   {
       //Body of Method
       Method();
   }       */
   
 // Recursion is derived from the word "Repitition".
 //Recursion is the process by virtue of which a Method can call itself.
 
 //  Requirement for Recursion : 
 // i) Method must call itself again  and again
// ii)The Method must have an exit Condition.

//The Return statement can be used either with or without values:

//=>Without values the Return statement is used to control the course of the program execution.
//=>With a list of values the Return statement is used to pass the values to the calling routine


              //Print all the numbers from 1 to 10 : 

namespace Recursion
{ 
    class Program
    {
        int num=1;
        void Counting()
        {
            // Exit Conditon
            if(num==11)
            {
                return;
            }
            Console.WriteLine(num);
            num++;
            Counting();
        }
        
        static void Main(string[] args)
        {
           Program obj = new Program();
           obj.Counting();
        }
    }
}
