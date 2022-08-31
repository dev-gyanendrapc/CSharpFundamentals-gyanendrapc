namespace Packt.Plant;
class Plant
{
    string name, group, color;
    public bool isEatable;
    bool isSelleble;

    public bool IsSelleble{
        get{
           return isSelleble; 
        }
        set{
            if(isEatable){
                isSelleble = isEatable;
            }
        }
    }

    public Plant()
    {
        Console.WriteLine("Please Provide All The Required Details");

    }
    public Plant(string name, string group, string color, bool isEatable)
    {
        this.name = name;
        this.group = group;
        this.color= color;
        this.isEatable = isEatable;
    }
    public string GetColor()
    {
        return this.color;
    }

    public string GetGroup()
    {
        return this.group;
    }

    public string GetName()
    {
        return this.name;
    }
}