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
        
        public void PrintBalance()
        {
            Console.WriteLine($"Your balance is: {this.Balance}");
        }
        public void SaveToDatabase()
        {
            Console.WriteLine("Saved!");
        }
        public void UpdateBalance(decimal newBalance)
        {
            Balance = newBalance;
            SaveToDatabase();
        }
    }
}