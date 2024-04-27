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
    public void Division_DivideByZero_Error()
    {
        // preq-UNIT-TEST-6
        // Arrange
        const double a = 12;
        const double b = 0;
        
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }
    
    [Test]
    public void Equal_TwoDoubleValues_ReturnOne()
    {
        // preq-UNIT-TEST-7
        // Arrange
        const double a = 12;
        const double b = 12;
        const double expected = 1;
        
        // Act
        var result = Calculator.Equals(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.000000001));
    }
    
    [Test]
    public void Power_TwoDoubleValues_ReturnSum()
    {
        // preq-UNIT-TEST-8
        // Arrange
        const double a = 3;
        const double b = 4;
        const double expected = 81;
        
        // Act
        var result = Calculator.Pow(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.000000001));
    }
    
    [Test]
    public void Log_TwoDoubleValues_ReturnLogarithm()
    {
        // preq-UNIT-TEST-9
        // Arrange
        const double a = 3;
        const double b = 4;
        const double expected = .79248125036057815;
        
        // Act
        var result = Calculator.Log(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.000000001));
    }
    
    [Test]
    public void Log_aIsLessThanZero_ThrowsError()
    {
        // preq-UNIT-TEST-10
        // Arrange
        const double a = -3;
        const double b = 4;
        
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Log(a, b));
    }
    
    [Test]
    public void Log_bIsZero_ThrowsError()
    {
        // preq-UNIT-TEST-11
        // Arrange
        const double a = 2;
        const double b = 0;
        
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Log(a, b));
    }
    
    [Test]
    public void Root_TwoDoubleValues_ReturnsRoot()
    {
        // preq-UNIT-TEST-12
        // Arrange
        const double a = 8;
        const double b = 3;
        const double expected = 2;
        
        // Act
        var result = Calculator.Root(a, b);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.00000001));
    }
    
    [Test]
    public void Root_bIsZero_ThrowsError()
    {
        // preq-UNIT-TEST-13
        // Arrange
        const double a = 8;
        const double b = 0;
        
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Root(a, b));
    }
    
    [Test]
    public void Factorial_OneDoubleValue_ReturnsFactorial()
    {
        // preq-UNIT-TEST-14
        // Arrange
        const double a = 8;
        const double expected = 40320;
        
        // Act
        var result = Calculator.Factorial(a);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.00000001));
    }
    
    [Test]
    public void Factorial_Zero_ReturnsOne()
    {
        // preq-UNIT-TEST-15
        // Arrange
        const double a = 0;
        const double expected = 1;
        
        // Act
        var result = Calculator.Factorial(a);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.00000001));
    }
    
    [Test]
    public void Factorial_One_ReturnsOne()
    {
        // Code Coverage Test
        // Arrange
        const double a = 1;
        const double expected = 1;
        
        // Act
        var result = Calculator.Factorial(a);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.00000001));
    }
    
    [Test]
    public void Factorial_NegativeDoubleValue_ReturnsFactorial()
    {
        // Code Coverage Test
        // Arrange
        const double a = -4;
        const double expected = -24;
        
        // Act
        var result = Calculator.Factorial(a);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.00000001));
    }
    
    [Test]
    public void Sine_OneDoubleValue_ReturnsValue()
    {
        // preq-UNIT-TEST-16
        // Arrange
        const double a = 5;
        const double expected = -0.95892427466;
        
        // Act
        var result = Calculator.Sin(a);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.00000001));
    }
    
    [Test]
    public void Cosine_OneDoubleValue_ReturnsValue()
    {
        // preq-UNIT-TEST-17
        // Arrange
        const double a = 5;
        const double expected = 0.28366218546;
        
        // Act
        var result = Calculator.Cos(a);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.00000001));
    }
    
    [Test]
    public void Tangent_OneDoubleValue_ReturnsValue()
    {
        // preq-UNIT-TEST-18
        // Arrange
        const double a = 5;
        const double expected = -3.38051500625;
        
        // Act
        var result = Calculator.Tan(a);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.00000001));
    }
    
    [Test]
    public void Reciprocal_OneDoubleValue_ReturnsValue()
    {
        // preq-UNIT-TEST-19
        // Arrange
        const double a = 5;
        const double expected = .2;
        
        // Act
        var result = Calculator.OneOver(a);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(.00000001));
    }
    
    [Test]
    public void Reciprocal_OneOverZero_ThrowsError()
    {
        // preq-UNIT-TEST-20
        // Arrange
        const double a = 0;
        
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.OneOver(a));
    }
}