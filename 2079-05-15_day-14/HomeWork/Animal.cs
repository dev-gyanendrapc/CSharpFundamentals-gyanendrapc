namespace Packt.Animal;

class Animal
{

    public string name, group, color;
    public Animal()
    {
        Console.WriteLine("Please Provide All The Required Details");
    }
    public Animal(string name, string group, string color)
    {
        this.name = name;
        this.group = group;
        this.color = color;
    }
}