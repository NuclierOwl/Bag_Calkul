using NUnit.Framework;
using System;
using System.Windows.Forms;
using form;

[TestFixture]
public class CalculatorTests
{
    private Form1 _calculator;
    private Button _dummyButton;

    private void SimulateButtonClick(string buttonText)
    {
        var button = new Button { Text = buttonText };
        _calculator.button_click(button, EventArgs.Empty);
    }

    private void SimulateOperatorClick(string operation)
    {
        var button = new Button { Text = operation };
        _calculator.operator_click(button, EventArgs.Empty);
    }


    [TearDownAttribute]
    public void OneTimeS()
    {
        _calculator.Dispose();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        _dummyButton?.Dispose();
    }


    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        _dummyButton = new Button();
    }

    [SetUp]
    public void Setup()
    {
        _calculator = new Form1();
        _calculator.button5_Click(_dummyButton, EventArgs.Empty);
    }

    [Test]
    public void InitialState_AllPropertiesHaveDefaultValues()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_calculator.textBox_Result.Text, Is.EqualTo("0"));
            Assert.That(_calculator.resultValue, Is.EqualTo(0));
            Assert.That(_calculator.operationPerformed, Is.Empty);
            Assert.That(_calculator.isOperationPerformed, Is.False);
        });
    }

    [TestCase("1", "1")]
    [TestCase("5", "5")]
    [TestCase("6", "6")]
    [TestCase("7", "7")]
    [TestCase("8", "8")]
    [TestCase("0", "0")]
    [TestCase("3", "3")]
    [TestCase("9", "9")]
    [TestCase("2", "2")]
    [TestCase("4", "4")]
    [TestCase(",", ",")]
    [TestCase("Часнык", "Часнык")]
    public void NumberButtonClick_SingleDigit_UpdatesDisplayCorrectly(string input, string exp)
    {
        SimulateButtonClick(input);
        Assert.That(_calculator.textBox_Result.Text, Is.EqualTo(exp));
    }

    [TestCase("+", "+")]
    [TestCase("-", "-")]
    [TestCase("/", "/")]
    [TestCase("*", "*")]
    public void OperButtonClick_SingleDigit_UpdatesDisplayCorrectly(string input, string expected)
    {
        SimulateOperatorClick(input);
        Assert.That(_calculator.operationPerformed, Is.EqualTo(expected));
    }

    [Test]
    public void MultipleNumberButtonClicks_AppendsDigitsCorrectly()
    {
        SimulateButtonClick("1");
        SimulateButtonClick("2");
        SimulateButtonClick("3");

        Assert.That(_calculator.textBox_Result.Text, Is.EqualTo("123"));
    }



    [Test]
    public void DecimalPointInput_AddDecimalOnce()
    {
        SimulateButtonClick("5");
        SimulateButtonClick(",");
        SimulateButtonClick("2");
        SimulateButtonClick(",");

        Assert.That(_calculator.textBox_Result.Text, Is.EqualTo("5,2"));
    }

    [TestCase("5", "+", "3", "8")]
    [TestCase("10", "-", "4", "6")]
    [TestCase("7", "*", "3", "21")]
    [TestCase("15", "/", "3", "5")]
    [TestCase("0,6", "+", "0,09", "0,69")]
    [TestCase("90", "-", "4,5", "85,5")]
    [TestCase("1,5", "*", "3", "4,5")]
    [TestCase("30", "/", "0,3", "100")]
    [TestCase("0", "/", "0,3", "0")]
    [TestCase("30", "/", "0", "Деление на 0")]
    [TestCase("Бульба", "+", "цыбуля", "Неверный ввод")]
    [TestCase("Бульба", "-", "цыбуля", "Неверный ввод")]
    [TestCase("Бульба", "/", "цыбуля", "Неверный ввод")]
    [TestCase("Бульба", "*", "цыбуля", "Неверный ввод")]
    public void Operations_CalculaterCorrectResults(
        string oper1, string operation, string oper2, string exp)
    {
        foreach (var c in oper1) SimulateButtonClick(c.ToString());

        SimulateOperatorClick(operation);

        foreach (var c in oper2) SimulateButtonClick(c.ToString());

        _calculator.button15_Click(_dummyButton, EventArgs.Empty);

        Assert.That(_calculator.textBox_Result.Text, Is.EqualTo(exp));
    }

    [TestCase("30", "sin", "0,5")]
    [TestCase("60", "cos", "0,5")]
    [TestCase("90", "sin", "1")]
    [TestCase("0", "cos", "1")]
    [TestCase("Бульба", "cos", "Неверный ввод")]
    [TestCase("Бурак", "sin", "Неверный ввод")]
    public void TrigonometricOperations_CalculaterCorrectResults(
        string a, string function, string exp)
    {
        foreach (var c in a) SimulateButtonClick(c.ToString());

        SimulateOperatorClick(function);
        _calculator.button15_Click(_dummyButton, EventArgs.Empty);

        Assert.That(_calculator.textBox_Result.Text, Does.StartWith(exp));
    }

    [Test]
    public void ClearEntryButton_ResetsDisplayNotOperation()
    {
        SimulateButtonClick("9");
        SimulateOperatorClick("+");
        SimulateButtonClick("5");

        _calculator.button4_Click(_dummyButton, EventArgs.Empty);

        Assert.Multiple(() =>
        {
            Assert.That(_calculator.textBox_Result.Text, Is.EqualTo("0"));
            Assert.That(_calculator.resultValue, Is.EqualTo(9));
            Assert.That(_calculator.operationPerformed, Is.EqualTo("+"));
        });
    }

    [Test]
    public void ClearAllButton_ResetsCalculatorCompletely()
    {
        SimulateButtonClick("8");
        SimulateOperatorClick("+");
        SimulateButtonClick("2");

        _calculator.button5_Click(_dummyButton, EventArgs.Empty);

        Assert.Multiple(() =>
        {
            Assert.That(_calculator.textBox_Result.Text, Is.EqualTo("0"));
            Assert.That(_calculator.resultValue, Is.EqualTo(0));
            Assert.That(_calculator.operationPerformed, Is.Empty);
            Assert.That(_calculator.isOperationPerformed, Is.False);
        });
    }

    [Test]
    public void OperationMnogo_ContinuesWithPreviousResult()
    {
        SimulateButtonClick("8");
        SimulateOperatorClick("+");
        SimulateButtonClick("800");
        _calculator.button15_Click(_dummyButton, EventArgs.Empty);

        SimulateOperatorClick("+");
        SimulateButtonClick("555");
        _calculator.button15_Click(_dummyButton, EventArgs.Empty);
        
        SimulateOperatorClick("+");
        SimulateButtonClick("35");
        _calculator.button15_Click(_dummyButton, EventArgs.Empty);
        
        SimulateOperatorClick("+");
        SimulateButtonClick("35");
        _calculator.button15_Click(_dummyButton, EventArgs.Empty);

        Assert.That(_calculator.textBox_Result.Text, Is.EqualTo("1433"));
    }

}