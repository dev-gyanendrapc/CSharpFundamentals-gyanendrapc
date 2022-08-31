namespace Inheritance;
class Car : Vehicle, IEngine
{
    public string? Model { get; set; }

    public void PrintCarFeatures()
    {
        Console.WriteLine("\nCar features:\n\t-Airbags\n\t-4X4 wheel drive\n\tHybrid Engine");
    }

    public void Start()
    {
    }

    public void ListParts()
    {
    }
}