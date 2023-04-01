using main.MainClasses;

Console.Write("Choose action between computer assembly(CA) or purchase simulation(PS): ");
var actionChoose = Console.ReadLine();

switch (actionChoose)
{
    case "CA":
        var computer = new Computer();

        computer.AddDetailToComputer();
        
        break;
    
    case "PS":
        
        Console.Write("Enter your budget, I know .. you saved it at school lunches: ");
        var budgetUser = double.Parse(Console.ReadLine());
        Console.Write("Enter a budget of filter(max price of detail): ");
        var budgetFilter = double.Parse(Console.ReadLine());
        var cart = new Cart();
        cart.AddDetailToCart(budgetUser, budgetFilter, Stock.MotherBoardsShop, Stock.CpusShop, Stock.GpusShop, Stock.RamsShop, Stock.DrivesShop);
        
        break;
    
    default:
        Console.WriteLine("Entered incorrect action!");
        break;
}


