namespace Packt.Plant;

class Vegetable : Plant, IForFood
{
    //defining default constructor
    public Vegetable()
    {

    }
    //constructor to get and set pass values in base class
    public Vegetable(string name, string group, string color, bool isEatable) : base(name, group, color, isEatable)
    {

    }

    public bool IsEatabl()
    {
        return base.isEatable;
    }

    bool IForFood.IsSelleble()
    {
        return base.IsSelleble;
    }
    //implementing interface methods



}