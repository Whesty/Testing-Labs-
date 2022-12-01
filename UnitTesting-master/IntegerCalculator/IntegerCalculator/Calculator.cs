namespace IntegerCalculator;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Modulus(int a, int b)
    {
        return a % b;
    }

    public int Power(int a, int b)
    {
        return (int)Math.Pow(a, b);
    }

    public int Factorial(int a)
    {
        if (a < 0)
            throw new ArgumentException("Factorial is not defined for negative numbers");
        var result = 1;
        for (var i = 1; i <= a; i++) result *= i;
        return result;
    }
}