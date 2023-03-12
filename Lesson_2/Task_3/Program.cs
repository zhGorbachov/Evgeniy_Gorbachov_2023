var random = new Random();
List<Customer> customers = new List<Customer>(10) 
{
    new Customer("Evgeniy", random.Next(1, 100), "Poltavskaya"),
    new Customer("Misha", random.Next(1, 100), "Kovelovka"),
    new Customer("Serega", random.Next(1, 100), "Popova"),
    new Customer("Roma", random.Next(1, 100), "Nikolaevka"),
    new Customer("Vito", random.Next(1, 100), "Siciliya"),
    new Customer("George", random.Next(1, 100), "Lelekovka"),
    new Customer("Yehor", random.Next(1, 100), "Rayon 55"),
    new Customer("Vova", random.Next(1, 100), "Volkovo"),
    new Customer("Solaire ", random.Next(1, 100), "Astora"),
    new Customer("Sigward", random.Next(1, 100), "Catharina"),
};

Console.Write("Enter name of customer: ");
string nameOfCustomer = Console.ReadLine();

foreach(var customer in customers)
{
    Console.WriteLine(customer.Name);
}

var selected = from x in customers where x.Name == nameOfCustomer where x.Age >= 18 select x;
Console.WriteLine("==========================");

foreach(var human in selected)
{
    Console.WriteLine($"{human.Name} {human.Age}: {human.Address}");
}







class Customer
{
    public string Name { get; }
    public int Age { get; }
    public string Address { get; }
    public Customer(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}