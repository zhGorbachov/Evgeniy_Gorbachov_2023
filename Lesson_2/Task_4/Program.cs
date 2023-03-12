List<Owner> owners = new List<Owner>()
{
    new Owner(1, "Evgeniy", "Street_1"),
    new Owner(2, "Misha", "Street_2"),
    new Owner(3, "Yehor", "Street_3"),
    new Owner(4, "Maksim", "Street_4"),
    new Owner(5, "Sanya", "Street_5")
};

List<Car> cars = new List<Car>()
{
    new Car("BA3000AK", 1),
    new Car("BA7911KA", 2),
    new Car("BA1010CT", 3),
    new Car("AK8901AA", 4),
    new Car("AA7777AK", 5),
};

Console.Write("Enter number of car: ");
string numberCar = Console.ReadLine();

var selected = from x in owners from y in cars where y.Number == numberCar where x.Id == y.OwnerId select x;
Console.WriteLine("======================");

foreach (var owner in selected) Console.WriteLine($"{owner.Id}: {owner.Name} on the {owner.Address}");


class Owner
{
    public int Id { get; }
    public string Name { get; }
    public string Address { get; }
    public Owner(int id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
}

class Car
{
    public string Number { get; }
    public int OwnerId { get; }
    public Car(string number, int ownerId)
    {
        Number = number;
        OwnerId = ownerId;
    }
}
