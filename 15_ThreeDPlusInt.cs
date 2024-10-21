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
    public static ThreeD operator +(ThreeD obj1,int num)
    {
        ThreeD result = new ThreeD(0,0,0);
        result.x=obj1.x+num;
        result.y=obj1.y+num;
        result.z=obj1.z+num;
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
        Console.Write("Here is , obj: ");
        obj.show();
        
       ThreeD result = obj+10;
       Console.Write("obj + 10 = ");
       result.show();
    }
}
