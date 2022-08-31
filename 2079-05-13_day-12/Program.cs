using Inheritance;

Vehicle v1 = new();
v1.Mileage = 12.3f;
v1.VNumber = "Ba. Pa. 23 2345";
v1.load = 10.5;
v1.Print();

Vehicle v2 = new();
v2.Mileage = 12.3f;
v2.VNumber = "Ba. Pa. 23 2345";
v2.load = 10.5;
v2.Print();

Car c1 = new();
c1.PrintCarFeatures();

IEngine t1 = new Truck();
t1 = new Car();