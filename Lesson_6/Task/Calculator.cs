namespace Task;

public class Calculator
{
    public delegate double Action(double firstNumber, double secondNumber);

    public delegate void ActionHandler(string information);

    public event ActionHandler? Calculation;
    
    // Function of calculator works
    
    public Action Sum = (firstNumber, secondNumber) => firstNumber + secondNumber;
    
    public Action Minus = (firstNumber, secondNumber) => firstNumber - secondNumber;
        
    public Action Multiply = (firstNumber, secondNumber) => firstNumber * secondNumber;

    public Action Devision = (firstNumber, secondNumber) =>
    {
        if (secondNumber != 0)
            return firstNumber / secondNumber;

        throw new DivideByZeroException();
    };
            
    public Action Exponentiation = (firstNumber, secondNumber) => Math.Pow(firstNumber, secondNumber);

    public void Calculating(double firstNumber, double secondNumber, Action action) =>
        Calculation?.Invoke($"First and second number gives {action(firstNumber, secondNumber)}");
    
    public void ShowResult(string information)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(information);
    }

    public void StartCalculator()
    {
        // User input
        Console.Write("Enter your action,\n" +
                      "it cans be: +, -, *, /, ^: ");

        char userAction = Char.Parse(Console.ReadLine());

        Console.Write("Enter first number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float secondNumber = float.Parse(Console.ReadLine());


        // Switch
        Calculation += ShowResult;

        switch (userAction)
        {
            case '+':
                Calculating(firstNumber, secondNumber, Sum);
                
                break;
            case '-':
                Calculating(firstNumber, secondNumber, Minus);                
                break;
            case '*':
                Calculating(firstNumber, secondNumber, Multiply);                
                break;
            case '/':
                Calculating(firstNumber, secondNumber, Devision);
                break;
            case '^':
                Calculating(firstNumber, secondNumber, Exponentiation);
                break;
            case 'e':
                Console.WriteLine("\n\nProgram shuts down...");
                break;
            default:
                Console.WriteLine("Wrong action, please read more carefully");
                break;
        }
    }
    
}