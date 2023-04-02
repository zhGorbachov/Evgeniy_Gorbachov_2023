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

        public void GetBalance(int id, List<Customer> customersList)
        {
            Console.WriteLine($"Your balance is: {GetBalanceById(id, customersList)}");
        }
        public decimal GetBalanceById(int id, List<Customer> customersList)
        {
            var customer = GetById(id, customersList);
            return customer.Balance;
        }
        public Customer GetById(int id, List<Customer> customersList)
        {
            return customersList.FirstOrDefault(x => x.Id == id);
        }
        public void SaveToDatabase()
        {
            Console.WriteLine("Saved!");
        }
        public void UpdateBalance(int id, decimal newBalance, List<Customer> customersList)
        {
            var customer = GetById(id, customersList);
            customer.Balance = newBalance;
            SaveToDatabase();
        }
    }
}