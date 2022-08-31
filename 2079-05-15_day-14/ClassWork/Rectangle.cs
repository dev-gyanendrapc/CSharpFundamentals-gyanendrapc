namespace Rectangle1;

public class Rectangle: IShape
{
    double length, breadth;

    public Rectangle(double l, double b)
    {
        length = l;
        breadth = b;
    }

    public double GetArea() => length * breadth;
    public double GetPerimeter() => (2 * (length + breadth));

}