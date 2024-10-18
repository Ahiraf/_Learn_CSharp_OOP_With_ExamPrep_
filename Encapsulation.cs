using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

//The meaning of Encapsulation is , "Hiding Sensitive Data".
//Encapsulation in Java is a mechanism of "Wrapping the data(variables) and code acting on the data(methods) together as a single unit"


/*namespace Encapsulation
{
    class Account
    {
        public int accountBalance = 1000;
    }
    class Program
    {
        
        public static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.accountBalance(100);
            // Here the user has changed the value of accountBalance from 1000 to 100.
        }
    }
}*/

//From the above code, it is clear that anyone can easily access the value of accountBalance. However, it is a sensitive variable that should not be accessed by any other classes. Therefore, we should use the principle of 'Encapsulation' to protect the variable.



               // How to achieve "Encapsulation" : 
               
//Encapsulation can be achieved in two steps :   
// i)Declare the variables of a class as private.(Data Hiding)
//ii)Provide public setter and getter methods to modify and view the variables values.
//Setter Method : To modify the value of Private variable
//Get Method : To get Value 
               
namespace Encapsulation
{
    class Account
    {
        public int accountBalance = 1000;
        public void SetBalance(int amount)
        {
            accountBalance = amount;
        }
        public void GetBalance()
        {
            Console.WriteLine("Your Account Balance is : "+accountBalance);
        }
    }
    class Program
    {
        
        public static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.SetBalance(10000);
            myAccount.GetBalance();
          
        }
    }
}






