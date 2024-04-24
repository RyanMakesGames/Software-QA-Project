using Microsoft.AspNetCore.Components;
namespace Calculator.Frontend.Components.Pages;

public partial class Home
{
    private string num1;
    private string num2;
    private string finalresult;

    private void AddNumbers()
    {
        finalresult = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
    }

    private void SubtractNumbers()
    {
        finalresult = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
    }

    private void MultiplyNumbers()
    {
        finalresult = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
    }

    private void DivideNumbers()
    {
        if (Convert.ToDouble(num2) != 0)
        {
            finalresult = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
        }
        else
        {
            finalresult = "Cannot Divide By Zero";
        }
    }

    private void Power()
    {
        var a = Convert.ToDouble(num1);
        var b = Convert.ToDouble(num2);
        var result = Math.Pow(a, b);
        finalresult = result.ToString();
    }

    private void Log()
    {
        var a = Convert.ToDouble(num1);
        var b = Convert.ToDouble(num2);
        var result = Math.Log(a, b);
        finalresult = result.ToString();
    }

    private void Factorial()
    {
        var a = Convert.ToDouble(num1);
        var result = FactorialOperation(a);
        finalresult = result.ToString();
    }

    private double FactorialOperation(double a)
    {
        if (a == 0)
        {
            return 0;
        }
        else if (a < 0)
        {
            var b = a + 1;
            return a * FactorialOperation(b);
        }
        else if (a > 1)
        {
            var b = a - 1;
            return a * FactorialOperation(b);
        }
        else
        {
            return 1;
        }
    }

    private void Root()
    {
        var a = Convert.ToDouble(num1);
        var b = Convert.ToDouble(num2);
        var result = Math.Pow(a, 1.0 / b);
        finalresult = result.ToString();
    }

    private void Sin()
    {
        var a = Convert.ToDouble(num1);
        var result = Math.Sin(a);
        finalresult = result.ToString();
    }

    private void Cos()
    {
        var a = Convert.ToDouble(num1);
        var result = Math.Cos(a);
        finalresult = result.ToString();
    }

    private void Tan()
    {
        var a = Convert.ToDouble(num1);
        var result = Math.Tan(a);
        finalresult = result.ToString();
    }

    private void DivA()
    {
        var a = Convert.ToDouble(num1);
        if (a != 0)
        {
            finalresult = (1 / a).ToString();
        }
        else
        {
            finalresult = "Cannot Divide By Zero";
        }
    }

    private void Equal()
    {
        if (Convert.ToDouble(num1) == Convert.ToDouble(num2))
        {
            finalresult = "1";
        }
        else
        {
            finalresult = "0";
        }
    }

    private void Clear()
    {
        finalresult = "Enter values below and select an operation.";
        num1 = "0";
        num2 = "0";
    }
}