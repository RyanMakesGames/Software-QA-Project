using Microsoft.Playwright;

namespace CalculatorEndtoEnd;
public class Tests
{
    private IPlaywright _playwright;
    private IBrowser _browser;
    private IPage _page;
    
    [SetUp]
    public async Task Setup()
    {
        _playwright = await Playwright.CreateAsync();
        _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        _page = await _browser.NewPageAsync();
    }

    [Test]
    public async Task WebApp_PageTitle_IsCalculator()
    {
        // preq-E2E-TEST-5
        await _page.GotoAsync("http://localhost:5272");
        string title = await _page.TitleAsync();
        Assert.AreEqual("Calculator", title);
    }
    
    [Test]
    public async Task WebApp_AddOperation_DisplaysCorrect()
    {
        // preq-E2E-TEST-6
        await _page.GotoAsync("http://localhost:5272");

        await _page.WaitForTimeoutAsync(100);
        
        // Input values into fields A and B
        await _page.FillAsync("#math_inputa", "5");
        await _page.FillAsync("#math_inputb", "7");

        // Click the Add button
        await _page.ClickAsync("#math_button");
        
        // Retrieve the result
        string result = await _page.EvaluateAsync<string>("() => document.querySelector('#result').textContent");

        // Verify the result
        int sum = 5 + 7; // Calculate the expected sum
        Assert.AreEqual("5 + 7 = " + sum.ToString(), result);
    }
    
    [Test]
    public async Task WebApp_DivideByZero_ThrowsError()
    {
        // preq-E2E-TEST-7
        await _page.GotoAsync("http://localhost:5272");

        await _page.WaitForTimeoutAsync(100);
        
        // Input values into fields A and B
        await _page.FillAsync("#math_inputa", "5");
        await _page.FillAsync("#math_inputb", "0");

        // Click the Divide button
        await _page.ClickAsync("#math_button2");
        
        // Retrieve the result
        string result = await _page.EvaluateAsync<string>("() => document.querySelector('#result').textContent");

        // Verify the result
        Assert.AreEqual("5 / 0 = Not a Number", result);
    }
    
    [Test]
    public async Task WebApp_ClearButton_Reset()
    {
        // preq-E2E-TEST-9
        await _page.GotoAsync("http://localhost:5272");

        await _page.WaitForTimeoutAsync(100);
        
        // Input values into fields A and B
        await _page.FillAsync("#math_inputa", "7");
        await _page.FillAsync("#math_inputb", "5");

        // Click the Divide button
        await _page.ClickAsync("#math_button");
        
        // Clear Button
        await _page.ClickAsync("#Clear");
        
        await _page.WaitForTimeoutAsync(1000);
        
        // Retrieve the result
        string result = await _page.EvaluateAsync<string>("() => document.querySelector('#result').textContent");
        string inputa = await _page.EvaluateAsync<string>("() => document.querySelector('#math_inputa').value");
        string inputb = await _page.EvaluateAsync<string>("() => document.querySelector('#math_inputb').value");
        
        // Verify the result
        Assert.AreEqual("Enter Values and Select Operation", result);
        Assert.AreEqual("0", inputa);
        Assert.AreEqual("0", inputb);
    }

    [TearDown]
    public void Teardown()
    {
        _page.CloseAsync().GetAwaiter().GetResult();
        _browser.CloseAsync().GetAwaiter().GetResult();
        _playwright.Dispose();
    }
}