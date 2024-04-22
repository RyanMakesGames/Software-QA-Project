namespace Calculator.Frontend.Components.Pages;

public partial class Home
{
    private static double Plus(double a, double b)
    {
        return a + b;
    }

    private static double Minus(double a, double b)
    {
        return a - b;
    }

    private static double Multiply(double a, double b)
    {
        return a * b;
    }

    private static double Divide(double a, double b)
    {
        return a / b;
    }

    private static double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }

    private static double Log(double a, double b)
    {
        return Math.Log(a, b);
    }

    private static double Root(double a, double b)
    {
        return Math.Pow(a, 1.0 / b);
    }

    private static double Factorial(double a)
    {
        if (a == 0)
        {
            return 1;
        }
        else if (a < 0)
        {
            return a * Factorial(a++);
        }
        else
        {
            return a * Factorial(a--);
        }
    }

    private static double Sin(double a)
    {
        return Math.Sin(a);
    }

    private static double Cos(double a)
    {
        return Math.Cos(a);
    }

    private static double Tan(double a)
    {
        return Math.Tan(a);
    }
}