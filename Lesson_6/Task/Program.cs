using Task;

void ShowResult(string information)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(information);
}
        
// User input
Console.Write("Enter your action,\n" +
              "it cans be: +, -, *, /, ^: ");

char userAction = Char.Parse(Console.ReadLine());

Console.Write("Enter first number: ");
float firstNumber = float.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
float secondNumber = float.Parse(Console.ReadLine());

var calculator = new Calculator();

// Switch
calculator.Calculation += ShowResult;

switch (userAction)
{
    case '+':
        calculator.Calculating(firstNumber, secondNumber, calculator.Sum);
                
        break;
    case '-':
        calculator.Calculating(firstNumber, secondNumber, calculator.Minus);                
        break;
    case '*':
        calculator.Calculating(firstNumber, secondNumber, calculator.Multiply);                
        break;
    case '/':
        calculator.Calculating(firstNumber, secondNumber, calculator.Devision);
        break;
    case '^':
        calculator.Calculating(firstNumber, secondNumber, calculator.Exponentiation);
        break;
    case 'e':
        Console.WriteLine("\n\nProgram shuts down...");
        break;
    default:
        Console.WriteLine("Wrong action, please read more carefully");
        break;
}
