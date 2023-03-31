namespace SingleResponsibility;

public class Customers
{
    public List<Customer> ListCustomers { get; set; } = new List<Customer>()
    {
        new Customer(1, "Fikus", 0),
        new Customer(2, "VHarbar", 100000)
    };

    public void AddToList(Customer customer)
    {
        ListCustomers.Add(customer);
        SaveToDatabase();
    }

    public void PrintBalance(int id)
    {
        Console.WriteLine($"Your balance is: {GetBalanceById(id)}");
    }
    
    public decimal GetBalanceById(int id)
    {
        var customer = GetById(id);
        return customer.Balance;
    }
    
    public Customer GetById(int id)
    {
        return ListCustomers.FirstOrDefault(x => x.Id == id);
    }
    public void SaveToDatabase()
    {
        Console.WriteLine("Saved!");
    }
    
}