using System; // If I didn't use it here I had to write every time before calling functions Like: System.Console.WriteLine()
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args) // The codes which I write under Main method , thats executes only
        {
 
           Console.WriteLine("Hello World");  //(System=Namespace, Console = Class , WriteLine = Method...has parantheses) => buil in 
            Console.WriteLine("Hello Mim");
            Console.WriteLine("Hello Urbi");
            Console.ReadLine(); //After pressing enter key the program exits
            //If i didn't use Console.ReadLine() the console would not pause and I couldnot see the outputs .
        }
    }
}


/*  //Assemblies Contain related Namespaces

namespace Math        // Namespace Contains related Classes
{
     class Calculator         // Class Contains related Methods
    {
               void Add()     //Method Contains related Codes
               {

  
               }

               void Sub()   //Contains related codes
              {


               }
               
    }
    class Formulas
    {

               void SquareRoot()
               {

               }
               
      }  

      
}



// Methods can be called after creating an object. But it can also be called by using static before the methods . Here is an example:

namespace Math        // Namespace Contains related Classes
{
     class Calculator         // Class Contains related Methods
    {
              static void Add()     //Method Contains related Codes
               {

  
               }

              static void Sub()   //Contains related codes
              {


               }
               
    }
    class Formulas
    {

              static void SquareRoot()
               {

               }
               
      }  

      
}

To call a method :
class App 
{ 
    static void Main() //entry point
    {
        Math.Calculator.Add();
    }
    
}

*/

