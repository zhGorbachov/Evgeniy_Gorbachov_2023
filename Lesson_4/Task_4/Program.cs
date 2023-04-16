using Task_4.Classes;
using Task_4.Interfaces;


var airplane = new Airplane();

var car = new Car();

var motorcycle = new Motorcycle();

var vehicles = new List<Vehicle>()
{
    motorcycle, airplane, car
};

airplane.Fly();

foreach (var veh in vehicles)
{
    Console.WriteLine(veh.GetType());
    veh.StartEngine();
}
