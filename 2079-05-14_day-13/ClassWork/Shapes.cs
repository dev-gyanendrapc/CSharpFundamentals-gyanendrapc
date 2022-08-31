namespace Panda.Shapes;

public class Shapes{
    public double Length {get; set;}
    public double Breadth {get; set;}
    public double Height {get; set;}
    public double Radius {get;set;}
    internal string Name(string sType){
        return $"Shape Type : {sType}";
    }
}