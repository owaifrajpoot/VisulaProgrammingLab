namespace PizzaOrderApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBoxSize = new ComboBox();
            label2 = new Label();
            checkBoxCheese = new CheckBox();
            checkBoxPepperoni = new CheckBox();
            checkBoxMushrooms = new CheckBox();
            label3 = new Label();
            radioButtonThinCrust = new RadioButton();
            radioButtonThickCrust = new RadioButton();
            buttonPlaceOrder = new Button();
            labelOrderSummary = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Pizza size";
            // 
            // comboBoxSize
            // 
            comboBoxSize.FormattingEnabled = true;
            comboBoxSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            comboBoxSize.Location = new Point(12, 36);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(121, 23);
            comboBoxSize.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Toppings";
            // 
            // checkBoxCheese
            // 
            checkBoxCheese.AutoSize = true;
            checkBoxCheese.Location = new Point(12, 104);
            checkBoxCheese.Name = "checkBoxCheese";
            checkBoxCheese.Size = new Size(64, 19);
            checkBoxCheese.TabIndex = 3;
            checkBoxCheese.Text = "Cheese";
            checkBoxCheese.UseVisualStyleBackColor = true;
            // 
            // checkBoxPepperoni
            // 
            checkBoxPepperoni.AutoSize = true;
            checkBoxPepperoni.Location = new Point(12, 129);
            checkBoxPepperoni.Name = "checkBoxPepperoni";
            checkBoxPepperoni.Size = new Size(80, 19);
            checkBoxPepperoni.TabIndex = 4;
            checkBoxPepperoni.Text = "Pepperoni";
            checkBoxPepperoni.UseVisualStyleBackColor = true;
            // 
            // checkBoxMushrooms
            // 
            checkBoxMushrooms.AutoSize = true;
            checkBoxMushrooms.Location = new Point(12, 154);
            checkBoxMushrooms.Name = "checkBoxMushrooms";
            checkBoxMushrooms.Size = new Size(90, 19);
            checkBoxMushrooms.TabIndex = 5;
            checkBoxMushrooms.Text = "Mushrooms";
            checkBoxMushrooms.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "Crust Type";
            label3.Click += label3_Click;
            // 
            // radioButtonThinCrust
            // 
            radioButtonThinCrust.AutoSize = true;
            radioButtonThinCrust.Location = new Point(12, 219);
            radioButtonThinCrust.Name = "radioButtonThinCrust";
            radioButtonThinCrust.Size = new Size(79, 19);
            radioButtonThinCrust.TabIndex = 7;
            radioButtonThinCrust.TabStop = true;
            radioButtonThinCrust.Text = "Thin Crust";
            radioButtonThinCrust.UseVisualStyleBackColor = true;
            // 
            // radioButtonThickCrust
            // 
            radioButtonThickCrust.AutoSize = true;
            radioButtonThickCrust.Location = new Point(12, 244);
            radioButtonThickCrust.Name = "radioButtonThickCrust";
            radioButtonThickCrust.Size = new Size(84, 19);
            radioButtonThickCrust.TabIndex = 8;
            radioButtonThickCrust.TabStop = true;
            radioButtonThickCrust.Text = "Thick Crust";
            radioButtonThickCrust.UseVisualStyleBackColor = true;
            // 
            // buttonPlaceOrder
            // 
            buttonPlaceOrder.Location = new Point(16, 279);
            buttonPlaceOrder.Name = "buttonPlaceOrder";
            buttonPlaceOrder.Size = new Size(75, 23);
            buttonPlaceOrder.TabIndex = 9;
            buttonPlaceOrder.Text = "Place Order";
            buttonPlaceOrder.UseVisualStyleBackColor = true;
            buttonPlaceOrder.Click += buttonPlaceOrder_Click;
            // 
            // labelOrderSummary
            // 
            labelOrderSummary.AutoSize = true;
            labelOrderSummary.Location = new Point(16, 324);
            labelOrderSummary.Name = "labelOrderSummary";
            labelOrderSummary.Size = new Size(0, 15);
            labelOrderSummary.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 463);
            Controls.Add(labelOrderSummary);
            Controls.Add(buttonPlaceOrder);
            Controls.Add(radioButtonThickCrust);
            Controls.Add(radioButtonThinCrust);
            Controls.Add(label3);
            Controls.Add(checkBoxMushrooms);
            Controls.Add(checkBoxPepperoni);
            Controls.Add(checkBoxCheese);
            Controls.Add(label2);
            Controls.Add(comboBoxSize);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxSize;
        private Label label2;
        private CheckBox checkBoxCheese;
        private CheckBox checkBoxPepperoni;
        private CheckBox checkBoxMushrooms;
        private Label label3;
        private RadioButton radioButtonThinCrust;
        private RadioButton radioButtonThickCrust;
        private Button buttonPlaceOrder;
        private Label labelOrderSummary;
    }
}
