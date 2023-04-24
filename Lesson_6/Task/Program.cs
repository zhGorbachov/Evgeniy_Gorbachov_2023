using Task;

Calculator.Action action;

Console.Write("Enter your action,\n" +
                  "it cans be: +, -, *, /, ^: ");

char userAction = Char.Parse(Console.ReadLine());

Console.Write("Enter first number: ");
float firstNumber = float.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
float secondNumber = float.Parse(Console.ReadLine());

switch (userAction)
{
    case '+':
        Calculator.Calculating(firstNumber, secondNumber, Calculator.Sum);
        break;
    case '-':
        Calculator.Calculating(firstNumber, secondNumber, Calculator.Minus);
        break;
    case '*':
        Calculator.Calculating(firstNumber, secondNumber, Calculator.Multiply);
        break;
    case '/':
        Calculator.Calculating(firstNumber, secondNumber, Calculator.Devision);
        break;
    case '^':
        Calculator.Calculating(firstNumber, secondNumber, Calculator.Exponentiation);
        break;
    case 'e':
        Console.WriteLine("\n\nProgram shuts down...");
        break;
    default:
        Console.WriteLine("Wrong action, please read more carefully");
        break;
}


