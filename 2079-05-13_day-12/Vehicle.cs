class Vehicle
{
    // setting default value N/A- not available
    public string VNumber { get; set; } = "N/A";
    public float Mileage { get; set; }
    public double load;

    public void Print()
    {
        var vehicleInfo = $"Plate : {VNumber} \nMieage : {Mileage} km/ltr \nLoad Capacity : {load} tons";
        Console.WriteLine(vehicleInfo);

    }
}