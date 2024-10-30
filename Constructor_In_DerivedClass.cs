using System;

class TwoDShape
{
    private double pre_width;
    private double pre_height;
    public double Width
    {
        get{return pre_width;}
        set{pre_width=value<0?(-value):value;}
    }
    public double Height
    {
        get{return pre_height;}
        set{pre_height=value<0?(-value):value;}
    }
}
class Triangle:TwoDShape
{
   public string style;
  public Triangle(string s,double i,double j)
  {
      Width = i;
      Height = j;
      style = s;
  }
  public double Area()
  {
      return Width*Height/2;
  }
  public void Show()
  {
      Console.WriteLine("The triangle is "+style);
  }
    
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Triangle ob = new Triangle("Isoscales",4.2,4.2);
       Triangle ob2 = new Triangle("Right",8,9);
       ob = ob2;
       double x= ob.Area();
       Console.WriteLine("The area is :"+x);
       ob.Show();
       ob2.Area();
       ob2.Show();
    }
}
