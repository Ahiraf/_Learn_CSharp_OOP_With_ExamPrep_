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
    public static bool operator true(ThreeD obj)
    {
        if(obj.x != 0 || obj.y != 0 || obj.z != 0){
            return true;
        }
        else return false;
    }
    public static bool operator false(ThreeD obj)
    {
        if(obj.x==0 && obj.y==0 && obj.z==0){
            return true;
        }
        else return false;
    }
    public void show()
    {
        Console.WriteLine(x+ "," +y +"," +z);
    }
}

public class TrueFalse
{
    public static void Main(string[] args)
    {  
        int x=int.Parse(Console.ReadLine());
        int y=int.Parse(Console.ReadLine());
        int z=int.Parse(Console.ReadLine());
        ThreeD PointA=new ThreeD(x,y,z); // as I make the constructor with parameters, I should call it with arguments.
        Console.Write("Here is , PointA: ");
        PointA.show();
        
        
        
        if(PointA)Console.WriteLine("Point A is not situated at the origin.");
        else {
            Console.WriteLine("Point A is situated at the origin.");
        }
    }
}
