namespace Panda.Shapes;
class Square : Shapes
{
    public double Area(double length)
    {
        return length * length;
    }
       public double Perimeter(double length)
    {
        return 4*length;
    }
}