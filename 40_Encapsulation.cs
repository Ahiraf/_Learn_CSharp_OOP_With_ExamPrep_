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
               
/*namespace Encapsulation
{
    class Account
    {
        public int accountBalance = 1000;
        public void SetBalance(int amount)
        {
            if(amount<0)
            {
                Console.WriteLine("You can not pass negative value");
            }
            else
            {
               accountBalance = amount;
            }
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
            myAccount.SetBalance(-10000);
            myAccount.GetBalance();
          
        }
    }
} */

// Thus using setter method user can control the Access from any other class to that class . 
// We can also use Properties without  using this get , set method.

// A property is like a combination of a variable and a method .
// And it contains two methods : a get and a set method .






            // The above code is written using "property" : 
            
namespace Encapsulation
{
    class Account
    {
        public int accountBalance = 1000;
        public int Balance
        {
            set
            {
                  if(value<0)
                  {
                        Console.WriteLine("You can not pass negative value");
                  }
                   else
                   {
                         // Since no parameter is used, "value" works as the value for accountBalance.
                    accountBalance = value; 
                   }
            }// Here, the accountBalance variable is being set by the Balance property.
           get
           {
                  return accountBalance;
            }
        }
    }
class Program
    {
        
        public static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.Balance = 10000;
            Console.WriteLine("Your account balance is :"+myAccount.Balance);
          
        }
    }
}

//If no set method is used, then the Property will be a "Read only Property". It means we can only read the value of accountBalance and cannot write or set it .
//If no get method is used,then the Property will be a "Write only Property". It means we can only write the value of accountBalance and cannot read or print it in the main method .
























