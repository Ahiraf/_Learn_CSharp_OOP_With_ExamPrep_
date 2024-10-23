using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

//With Method Overriding, we can override the method of Parent class with same Method of Child class


/*Conditions Method Overrinding : 
=> All the method should have "Same Name".
=>All the Methods should be in "Different Class".
=>But Methods should have "Same Parameters".
                           Same type of Parameters.
                           Same Numbers of Parameters.
                           Same Sequence of Parameters.
                           
=>There should be Inheritance between Classes.
*/


namespace MethodOverrinding
{
    class Animal    //Parent class
   {
      
       public void Eat()
       {
           Console.WriteLine("Animal is Eating");
       }      
   }
   class Dog:Animal     //Child class
   {
       public void Eat()
       {
           Console.WriteLine("Dog is Eating.");
       }
       public static void Main(string[] args)
       {
           Dog tommy = new Dog();
           tommy.Eat();
       }
   }
}

// Here, the method "Eat()" is the same in both the parent and child classes. This is called method overriding, where the method in the parent class has been overridden by the method in the child class.










