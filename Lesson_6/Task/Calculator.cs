namespace Task;

public static class Calculator
{
    public delegate double Action(float firstNumber, float secondNumber);

    // Function of calculator works
    
    public static double Sum(float firstNumber, float secondNumber) => firstNumber + secondNumber;

    public static double Minus(float firstNumber, float secondNumber) => firstNumber - secondNumber;
    
    public static double Multiply(float firstNumber, float secondNumber) => firstNumber * secondNumber;

    public static double Devision(float firstNumber, float secondNumber)
    {
        if (secondNumber != 0)
            return firstNumber / secondNumber;
        
        throw new DivideByZeroException();
    } 
    
    public static double Exponentiation(float firstNumber, float secondNumber) => Math.Pow(firstNumber, secondNumber);

    public static void Calculating(float firstNumber, float secondNumber, Action action) =>
        Console.WriteLine($"Result of numbers {firstNumber} and {secondNumber} = {action(firstNumber, secondNumber)}");

}