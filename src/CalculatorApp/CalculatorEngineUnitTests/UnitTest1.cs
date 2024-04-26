namespace CalculatorEngineUnitTests;
using CalculatorEngine;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Add_TwoDoubleValues_ReturnsSum()
    {
        // preq-UNIT-TEST-2
        // Arrange
        const double a = 3.2;
        const double b = 4.7;
        const double expected = 7.9;
        
        // Act
        var result = Calculator.Add(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.000000001));
    }
    
    [Test]
    public void Subtract_TwoDoubleValues_ReturnsSum()
    {
        // preq-UNIT-TEST-3
        // Arrange
        const double a = 5.9;
        const double b = 4.7;
        const double expected = 1.2;
        
        // Act
        var result = Calculator.Subtract(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.000000001));
    }
    
    [Test]
    public void Multiply_TwoDoubleValues_ReturnsSum()
    {
        // preq-UNIT-TEST-4
        // Arrange
        const double a = 2;
        const double b = 3;
        const double expected = 6;
        
        // Act
        var result = Calculator.Multiply(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.000000001));
    }
    
    [Test]
    public void Division_TwoDoubleValues_ReturnsSum()
    {
        // preq-UNIT-TEST-5
        // Arrange
        const double a = 12;
        const double b = 3;
        const double expected = 4;
        
        // Act
        var result = Calculator.Divide(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.000000001));
    }
    
    [Test]
    public void Division_TwoDoubleValues_Error()
    {
        // preq-UNIT-TEST-6
        // Arrange
        const double a = 12;
        const double b = 0;
        
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }
    
    [Test]
    public void Equal_TwoDoubleValues_Return1()
    {
        // preq-UNIT-TEST-7
        // Arrange
        const double a = 12;
        const double b = 0;
        const double expected = double.NaN;
        
        // Act
        var result = Calculator.Divide(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.000000001));
    }
}