namespace Panda.Shapes;

class Triangle{
    internal double Area(double b, double h){
        return (0.5*b*h);
    }
    internal double Perimeter(double l, double b, double h){
        return l+b+h;
    }

}