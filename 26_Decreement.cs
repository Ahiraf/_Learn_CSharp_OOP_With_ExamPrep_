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
    public static ThreeD operator --(ThreeD obj)
    {
        ThreeD result = new ThreeD(0,0,0);
        result.x=obj.x-1;
        result.y=obj.y-1;
        result.z=obj.z-1;
        return result;
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

public class Decreement
{
    public static void Main(string[] args)
    {  
        int x=int.Parse(Console.ReadLine());
        int y=int.Parse(Console.ReadLine());
        int z=int.Parse(Console.ReadLine());
        ThreeD PointA=new ThreeD(x,y,z); // as I make the constructor with parameters, I should call it with arguments.
        Console.Write("Here is , PointA: ");
        if(x==y && y==z && x==z){
         do{
             PointA.show();
             PointA--;
         }while(PointA);
        }
    }
}
