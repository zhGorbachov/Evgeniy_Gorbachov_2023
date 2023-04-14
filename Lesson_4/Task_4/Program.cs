using Task_4.Classes;
using Task_4.Interfaces;

var _vehicle = new Vehicle();

_vehicle.Airplane = new Flyable();

_vehicle.Airplane.Fly();

_vehicle.StartEngine();