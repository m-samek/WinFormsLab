using System;
using System.Windows.Forms;

namespace WinFormsLab
{
    public partial class Form1 : Form
    {
        double firstValue = 0;
        string value = "";
        private string currentOperator = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            value += (sender as Button).Text;
            wynikBox.Text = value;
        }

        private void buttonAdd_Click(object sender, EventArgs e) => SetOperator("+");
        private void buttonSub_Click(object sender, EventArgs e) => SetOperator("-");
        private void buttonMultiply_Click(object sender, EventArgs e) => SetOperator("*");
        private void buttonDivide_Click(object sender, EventArgs e) => SetOperator("/");

        private void SetOperator(string op)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (!string.IsNullOrEmpty(currentOperator))
                {
                    // Perform the calculation with the current operator before setting the new one
                    Calculate();
                }
                else
                {
                    firstValue = double.Parse(value);
                }
                value = "";
            }
            currentOperator = op;
        }

        private void buttonEquals_Click(object sender, EventArgs e) => Calculate();

        private void Calculate()
        {
            if (string.IsNullOrEmpty(value)) return;
            double secondValue = double.Parse(value);
            switch (currentOperator)
            {
                case "+": firstValue += secondValue; break;
                case "-": firstValue -= secondValue; break;
                case "*": firstValue *= secondValue; break;
                case "/": firstValue /= secondValue; break;
            }
            wynikBox.Text = firstValue.ToString();
            value = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            value = "";
            firstValue = 0;
            wynikBox.Text = "";
            currentOperator = "";
        }
    }
}
