namespace SingleResponsibility
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        
        public Customer(int id, string name, decimal balance)
        {
            Id = id; 
            Name = name; 
            Balance = balance;
        }

        public List<Customer> CustomersList = new List<Customer>()
        {
            new Customer(1, "Fikus", 0),
            new Customer(2, "VHarbar", 100000)
        };

        public void PrintBalanceById(int id)
        {
            Console.WriteLine($"Your balance is: {GetBalanceById(id)}");
        }
        public decimal GetBalanceById(int id)
        {
            var customer = GetCustomerById(id);
            return customer.Balance;
        }
        public Customer GetCustomerById(int id)
        {
            return CustomersList.FirstOrDefault(x => x.Id == id);
        }
        public void SaveToDatabase()
        {
            Console.WriteLine("Saved!");
        }
        public void UpdateBalanceCustomerById(int id, decimal newBalance)
        {
            var customer = GetCustomerById(id);
            customer.Balance = newBalance;
            SaveToDatabase();
        }
    }
}