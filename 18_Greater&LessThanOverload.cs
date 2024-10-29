using System;

// NB : C# binary operators (> and <) can only accept two operands.

public class ThreeD
{
    public int x,y,z;
    public ThreeD(int i,int j, int k)
    {
        x=i;
        y=j;
        z=k;
    }
    public static bool operator >(ThreeD obj1,ThreeD obj2)
    {
        if(Math.Sqrt(obj1.x*obj1.x + obj1.y*obj1.y + obj1.z*obj1.z)>(Math.Sqrt(obj2.x*obj2.x + obj2.y*obj2.y + obj2.z*obj2.z))){
            return true;
        }
        else return false;
    }
    public static bool operator <(ThreeD obj1,ThreeD obj2)
    {
        if(Math.Sqrt(obj1.x*obj1.x + obj1.y*obj1.y + obj1.z*obj1.z)<(Math.Sqrt(obj2.x*obj2.x + obj2.y*obj2.y + obj2.z*obj2.z))){
            return true;
        }
        else return false;
    }
    public void show()
    {
        Console.WriteLine(x+ "," +y +"," +z);
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {  
        int x=int.Parse(Console.ReadLine());
        int y=int.Parse(Console.ReadLine());
        int z=int.Parse(Console.ReadLine());
        ThreeD obj=new ThreeD(x,y,z); // as I make the constructor with parameters, I should call it with arguments.
        Console.Write("Here is , obj: ");
        obj.show();
        
        int x2=int.Parse(Console.ReadLine());
        int y2=int.Parse(Console.ReadLine());
        int z2=int.Parse(Console.ReadLine());
        ThreeD obj2=new ThreeD(x2,y2,z2); 
        Console.Write("Here is , obj2: ");
        obj2.show();
        
        
        if(obj>obj2)Console.WriteLine("Point A is further than B");
        else if(obj<obj2){
            Console.WriteLine("Point B is further than A");
        }
        else{
            Console.WriteLine("Point B and A are same point");
        }
    }
}
