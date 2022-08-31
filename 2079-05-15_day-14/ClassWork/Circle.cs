namespace Rectangle1;
public class Circle:IShape
{
    double radius;
    public Circle(double r){
        radius = r;
    }
     public double GetArea()=>Math.PI * radius*radius;
     public double GetPerimeter()=>2*Math.PI*radius;
}