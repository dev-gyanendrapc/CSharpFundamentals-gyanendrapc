namespace Panda.Shapes;
class Rectangle : Shapes
{
    public double Area(double width, double height)
    {
        return width * height;
    }
    public double Perimeter(double width, double height)
    {
        return (2 * (width + height));
    }
}