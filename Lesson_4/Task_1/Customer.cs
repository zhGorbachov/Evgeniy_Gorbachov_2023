namespace SingleResponsibility
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public List<Customer> CustomersList { get; set; } = new List<Customer>();
        
        public Customer(int id, string name, decimal balance)
        {
            Id = id; 
            Name = name; 
            Balance = balance;
            CustomersList.Add(this);
        }

        public void AddToCustomerList(Customer customer)
        {
            CustomersList.Add(customer);
        }

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
        public void UpdateBalanceById(int id, decimal newBalance)
        {
            var customer = GetCustomerById(id);
            customer.Balance = newBalance;
            SaveToDatabase();
        }
    }
}