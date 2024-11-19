namespace simplecalculator_task2
{
    public partial class Form1 : Form
    {
        private double value1 = 0;
        private string operation = "";
        private bool operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operationPressed)
                txtDisplay.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value1 = double.Parse(txtDisplay.Text);
            operationPressed = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double value2 = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (value1 + value2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (value1 - value2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (value1 * value2).ToString();
                    break;
                case "/":
                    if (value2 != 0)
                        txtDisplay.Text = (value1 / value2).ToString();
                    else
                        MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            operation = "";
            operationPressed = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            value1 = 0;
            operation = "";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void btnEquals_Click_1(object sender, EventArgs e)
        {
            btnEquals_Click(sender, e);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
        }

        private void btnDecimal_Click_1(object sender, EventArgs e)
        {
            btnDecimal_Click(sender, e);
        }
    }
}
