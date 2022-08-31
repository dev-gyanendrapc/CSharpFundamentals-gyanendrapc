

using Packt.Plant;
using Packt.Animal;

var plant = new Plant("someplant", "plant", "green", true);

Console.WriteLine(
    $"{plant.GetColor()} and {plant.IsSelleble}"
);