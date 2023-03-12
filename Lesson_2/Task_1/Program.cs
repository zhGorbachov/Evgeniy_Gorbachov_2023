List<Product> collection = new List<Product>(10);

for (int i = 0; i < 3; i++)
{
    Console.Write($"Enter {i + 1} name of product to collection: ");
    string name = Console.ReadLine();

    Console.Write($"Enter {i + 1} price of product to collection: ");
    int price = Convert.ToInt32(Console.ReadLine());

    Product product = new Product(name, price);
    collection.Add(product);
}

var sortCollection = collection.OrderBy(x => x.Price);

Console.WriteLine("Ascending\n========================");
foreach(var product in sortCollection) Console.WriteLine($"{product.Name}: {product.Price}");

Console.WriteLine("\nDescending\n========================");
foreach (var product in sortCollection.Reverse()) Console.WriteLine($"{product.Name}: {product.Price}");


class Product
{
    public string Name { get; }
    public int Price { get;}
    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}