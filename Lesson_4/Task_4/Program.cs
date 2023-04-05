using Task_4.Classes;

var vehicles = new List<Vehicle>();

var plane = new Plane();

var car = new Car();

var cycle = new Motorcycle();

vehicles.Add(plane);

vehicles.Add(car);

vehicles.Add(cycle);

foreach (var vehicle in vehicles)
{
    vehicle.Fly();
    Console.WriteLine($"Its was: {vehicle.GetType()}\n");
}
