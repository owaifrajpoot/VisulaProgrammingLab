namespace welcomeform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGreet_Click(object sender, EventArgs e)
        {
            // Check if the user entered a name
            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                // Display a personalized greeting
                labelMessage.Text = $"Hello, {textBoxName.Text}! Welcome!";
            }
            else
            {
                // Prompt the user to enter a name
                labelMessage.Text = "Please enter your name.";
            }
        }
    }
}
