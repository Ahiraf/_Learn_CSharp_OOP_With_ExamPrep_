using System;
using System.Collections.Generic;

class Person
{
    public string Name{get ; set ;}
    public int Age{get ; set;}
    public override string ToString()
    {
        return $"{Name} ,{Age} years old";
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
       List<Person> people = new List<Person> 
       {
       new Person  {Name = "Alice" , Age = 20},
       new Person  {Name = "Fariha" , Age = 14},
       new Person  {Name = "nova" , Age = 9}
       };
       
       people.Sort((p1,p2) => p1.Age.CompareTo(p2.Age));
       people.ForEach(p => Console.WriteLine(p));
       people.Sort((p1,p2) => p1.Name.CompareTo(p2.Name));
       people.ForEach(p => Console.WriteLine(p));
    }
}
