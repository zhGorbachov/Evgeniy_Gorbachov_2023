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
}