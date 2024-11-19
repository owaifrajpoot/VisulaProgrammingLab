namespace PizzaOrderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            // Get the selected pizza size
            string size = comboBoxSize.SelectedItem?.ToString() ?? "Not Selected";

            // Get the selected toppings
            List<string> toppings = new List<string>();
            if (checkBoxCheese.Checked) toppings.Add("Cheese");
            if (checkBoxPepperoni.Checked) toppings.Add("Pepperoni");
            if (checkBoxMushrooms.Checked) toppings.Add("Mushrooms");

            string toppingsSummary = toppings.Count > 0 ? string.Join(", ", toppings) : "No Toppings";

            // Get the selected crust type
            string crust = radioButtonThinCrust.Checked ? "Thin Crust" :
                           radioButtonThickCrust.Checked ? "Thick Crust" :
                           "Not Selected";

            // Build the order summary
            string orderSummary = $"Pizza Size: {size}\n" +
                                  $"Toppings: {toppingsSummary}\n" +
                                  $"Crust Type: {crust}";

            // Display the order summary in the label
            labelOrderSummary.Text = orderSummary;
        }

    }
}
