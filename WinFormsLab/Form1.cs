namespace WinFormsLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double firstValue = 0;
        string value = "";
        private string currentOperator = "";

        private void button1_Click(object sender, EventArgs e)
        {
            value = value + "1";
            wynikBox.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value = value + "2";
            wynikBox.Text = value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            value = value + "3";
            wynikBox.Text = value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            value = value + "4";
            wynikBox.Text = value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            value = value + "5";
            wynikBox.Text = value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            value = value + "6";
            wynikBox.Text = value;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            value = value + "7";
            wynikBox.Text = value;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            value = value + "8";
            wynikBox.Text = value;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            value = value + "9";
            wynikBox.Text = value;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            value = value + "0";
            wynikBox.Text = value;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {


            if (firstValue == 0)
            {
                firstValue = double.Parse(value);
                value = "";
            }
            else
            {
                double secondValue = double.Parse(value);
                firstValue += secondValue;
                value = firstValue.ToString();

            }
            wynikBox.Text = value;
            currentOperator = "+";

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }
    }
}
