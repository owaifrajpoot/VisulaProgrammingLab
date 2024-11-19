namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        private double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        private double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBoxNumber1.Text);
                double num2 = Convert.ToDouble(textBoxNumber2.Text);
                double result = Add(num1, num2);
                labelResult.Text = $"Result: {result}";
            }
            catch (Exception ex)
            {
                labelResult.Text = $"Error: {ex.Message}";
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBoxNumber1.Text);
                double num2 = Convert.ToDouble(textBoxNumber2.Text);
                double result = Subtract(num1, num2);
                labelResult.Text = $"Result: {result}";
            }
            catch (Exception ex)
            {
                labelResult.Text = $"Error: {ex.Message}";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBoxNumber1.Text);
                double num2 = Convert.ToDouble(textBoxNumber2.Text);
                double result = Multiply(num1, num2);
                labelResult.Text = $"Result: {result}";
            }
            catch (Exception ex)
            {
                labelResult.Text = $"Error: {ex.Message}";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBoxNumber1.Text);
                double num2 = Convert.ToDouble(textBoxNumber2.Text);
                double result = Divide(num1, num2);
                labelResult.Text = $"Result: {result}";
            }
            catch (Exception ex)
            {
                labelResult.Text = $"Error: {ex.Message}";
            }
        }
    }
}
