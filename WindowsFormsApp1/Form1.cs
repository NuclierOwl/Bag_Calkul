using System;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        public Double resultValue = 0;
        public String operationPerformed = "";
        public bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        public void button_click(object sender, EventArgs e) // работа с запятой
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!textBox_Result.Text.Contains(","))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
                textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        public void operator_click(object sender, EventArgs e) 
        {
            Button button = (Button)sender;
            double currentValue;

            if (!double.TryParse(textBox_Result.Text, out currentValue))
            {
                textBox_Result.Text = "Неверный ввод";
                return;
            }

            if (resultValue != 0)
            {
                button15.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = currentValue;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        public void button4_Click(object sender, EventArgs e) // очистка поля ввода
        {
            textBox_Result.Text = "0";
        }

        public void button5_Click(object sender, EventArgs e) // очистка поля ввода + операторы
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            operationPerformed = "";
            labelCurrentOperation.Text = "";
        }

        public void button15_Click(object sender, EventArgs e) // осуществление операций
        {
            double currentValue;
            if (!double.TryParse(textBox_Result.Text, out currentValue))
            {
                textBox_Result.Text = "Неверный ввод";
                labelCurrentOperation.Text = "";
                return;
            }

            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + currentValue).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - currentValue).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * currentValue).ToString();
                    break;
                case "/":
                    if (currentValue == 0)
                    {
                        textBox_Result.Text = "Деление на 0";
                    }
                    else
                    {
                        textBox_Result.Text = (resultValue / currentValue).ToString();
                    }
                    break;
                case "sin":
                    textBox_Result.Text = Math.Sin(currentValue * Math.PI / 180).ToString();
                    break;
                case "cos":
                    textBox_Result.Text = Math.Cos(currentValue * Math.PI / 180).ToString();
                    break;
                default:
                    break;
            }

            if (double.TryParse(textBox_Result.Text, out resultValue))
            {
                labelCurrentOperation.Text = "";
            }
        }
    }
}