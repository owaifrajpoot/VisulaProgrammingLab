namespace welcomeform
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
            labelPrompt = new Label();
            textBoxName = new TextBox();
            buttonGreet = new Button();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // labelPrompt
            // 
            labelPrompt.AutoSize = true;
            labelPrompt.Location = new Point(14, 10);
            labelPrompt.Name = "labelPrompt";
            labelPrompt.Size = new Size(96, 15);
            labelPrompt.TabIndex = 0;
            labelPrompt.Text = "Enter Your Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(554, 23);
            textBoxName.TabIndex = 1;
            // 
            // buttonGreet
            // 
            buttonGreet.Location = new Point(14, 89);
            buttonGreet.Name = "buttonGreet";
            buttonGreet.Size = new Size(75, 23);
            buttonGreet.TabIndex = 2;
            buttonGreet.Text = "Greet Me";
            buttonGreet.UseVisualStyleBackColor = true;
            buttonGreet.Click += buttonGreet_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(14, 145);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 15);
            labelMessage.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMessage);
            Controls.Add(buttonGreet);
            Controls.Add(textBoxName);
            Controls.Add(labelPrompt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrompt;
        private TextBox textBoxName;
        private Button buttonGreet;
        private Label labelMessage;
    }
}
