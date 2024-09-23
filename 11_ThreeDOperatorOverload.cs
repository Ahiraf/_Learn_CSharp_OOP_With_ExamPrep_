using System;

public class ThreeD
{
    public int x,y,z;
    public ThreeD(int i,int j, int k)
    {
        x=i;
        y=j;
        z=k;
    }
    public static ThreeD operator +(ThreeD obj1,ThreeD obj2)
    {
        ThreeD result = new ThreeD(0,0,0);
        result.x=obj1.x+obj2.x;
        result.y=obj1.y+obj2.y;
        result.z=obj1.z+obj2.z;
        return result;
        
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
        
       int x1=int.Parse(Console.ReadLine());
       int y1=int.Parse(Console.ReadLine());
       int z1=int.Parse(Console.ReadLine());
       ThreeD obj2=new ThreeD(x1,y1,z1);
       ThreeD result = obj+obj2;
       result.show();
    }
}
