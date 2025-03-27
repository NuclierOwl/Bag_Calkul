using Calculator;
using NUnit.Framework;
using System;
using System.Windows.Forms;

[TestFixture]
public class CalculTest
{
    private Form1 _form;

    [SetUp]
    public void SetUp()
    {
        _form = new Form1();
    }

    [TearDown]
    public void TearDown()
    {
        _form.Dispose();
    }

    [Test]
    public void operator_click_ShouldReturnCorrectSum_WhenBothNumbersAreNonNegative()
    {
        _form.textBox_Result.Text = "5";
        var button = new Button { Text = "+" };

        _form.operator_click(button, EventArgs.Empty);

        Assert.That(_form.resultValue, Is.EqualTo(10));
        Assert.That(_form.operationPerformed, Is.EqualTo("+"));
        Assert.That(_form.isOperationPerformed);
    }

    [Test]
    public void operator_click_Vikhitanie_WhenFirstNumberIsNegative()
    {
        _form.textBox_Result.Text = "-9";
        var button = new Button { Text = "-" };

        _form.operator_click(button, EventArgs.Empty);

        Assert.That(_form.resultValue, Is.EqualTo(0));
        Assert.That(_form.operationPerformed, Is.EqualTo("-"));
        Assert.That(_form.isOperationPerformed);
    }

    [Test]
    public void operator_click_ShouldThrowArgumentException_WhenSecondNumberIsNegative()
    {
        _form.textBox_Result.Text = "0";
        var button = new Button { Text = "*" };

        _form.operator_click(button, EventArgs.Empty);

        Assert.That(_form.resultValue, Is.EqualTo(0));
        Assert.That(_form.operationPerformed, Is.EqualTo("-"));
        Assert.That(_form.isOperationPerformed);
    }

    [Test]
    public void operator_click_ShouldReturnZero_WhenBothNumbersAreZero()
    {
        _form.textBox_Result.Text = "0";
        var button = new Button { Text = "/" };
        _form.textBox_Result.Text = "0";

        _form.operator_click(button, EventArgs.Empty);

        Assert.That(_form.resultValue, Is.EqualTo(0));
        Assert.That(_form.operationPerformed, Is.EqualTo("-"));
        Assert.That(_form.isOperationPerformed);
    }

    [Test]
    public void operator_click_ShouldReturnOne_Sinus()
    {
        _form.textBox_Result.Text = "90";
        var button = new Button { Text = "sin" };

        _form.operator_click(button, EventArgs.Empty);

        Assert.That(_form.resultValue, Is.EqualTo(1));
        Assert.That(_form.operationPerformed, Is.EqualTo("sin"));
        Assert.That(_form.isOperationPerformed);
    }

    [Test]
    public void operator_click_ShouldReturnOne_Cosinus()
    {
        _form.textBox_Result.Text = "0";
        var button = new Button { Text = "cos" };

        _form.operator_click(button, EventArgs.Empty);

        Assert.That(_form.resultValue, Is.EqualTo(1));
        Assert.That(_form.operationPerformed, Is.EqualTo("cos"));
        Assert.That(_form.isOperationPerformed);
    }
}