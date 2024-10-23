using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

/* 1. What is an Interface?
An interface is a contract that defines a set of methods, properties, events, or indexers that a class or struct must implement. Unlike classes, interfaces do not provide any implementation, just the signatures of the members.

2. Why Use Interfaces for Multiple Inheritance?
In C#, a class can only inherit from one base class (single inheritance), but it can implement multiple interfaces. This lets you simulate multiple inheritance by defining common behaviors in different interfaces and having your class implement all of them.

3. Example of Multiple Inheritance Using Interfaces
Let’s say we have two interfaces, IDriveable and IFlyable, and we want a class FlyingCar to implement both behaviors (driving and flying):


4. Key Points:
Interfaces provide no implementation: They only specify the "what" (method signatures), not the "how" (implementation).
A class like FlyingCar can implement multiple interfaces, thereby achieving behavior similar to multiple inheritance.
Each interface can represent a different aspect or capability (e.g., driving and flying), and the class implementing them can have both behaviors.
5. Advantages of Using Interfaces:
Separation of concerns: You can define small, focused interfaces and implement only the behaviors you need.
Loosely coupled code: Using interfaces allows for more flexible code where you can swap different implementations (e.g., mock objects for testing).
Multiple behaviors: Even though C# doesn’t allow multiple class inheritance, you can still give a class multiple behaviors by implementing multiple interfaces.
Would you like a more advanced example or more explanation about how interfaces interact with polymorphism in C#?

*/


namespace Interface
{
    public interface IDriveable
{
    void Drive();
}

public interface IFlyable
{
    void Fly();
}

public class FlyingCar : IDriveable, IFlyable
{
    public void Drive()
    {
        Console.WriteLine("The car is driving on the road.");
    }

    public void Fly()
    {
        Console.WriteLine("The car is flying in the sky.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        FlyingCar myFlyingCar = new FlyingCar();

        // You can call both Drive and Fly methods
        myFlyingCar.Drive();  // Output: The car is driving on the road.
        myFlyingCar.Fly();    // Output: The car is flying in the sky.
    }
}
    
}







