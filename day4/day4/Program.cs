using System.Drawing;

public interface Shape
{
    double GetArea();
}
 class Cricle:Shape
{
    double Radius;
    public Cricle( double radius)
    {
        Radius = radius;
    }
    public double GetArea()
    {
        return 3.14 * Radius * Radius;
    }
}
class Rectangle : Shape
{
    public double Length, Width;
    public Rectangle( double length,double width)
    {
        Width = width;
        Length = length;
    }
    public double GetArea()
    {
        return Length * Width;
    }
}
class Square : Shape
{
    public double Length;
    public Square(double length)
    {
        Length = length;
    }
     public double GetArea()
    {
       return Length * Length;
    }
}
class Program
{
    static void Main()
    {
        Cricle c1 = new Cricle(2.5);
        Rectangle r1 = new Rectangle(4, 3);
        Square s1 = new Square(5);

        Console.WriteLine("Circle Area: " + c1.GetArea());
        Console.WriteLine("Rectangle Area: " + r1.GetArea());
        Console.WriteLine("Square Area: " + s1.GetArea());

    }
}