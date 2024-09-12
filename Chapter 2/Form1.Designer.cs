namespace Chapter_2
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
            messageButton = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // messageButton
            // 
            messageButton.Location = new Point(12, 12);
            messageButton.Name = "messageButton";
            messageButton.Size = new Size(75, 39);
            messageButton.TabIndex = 0;
            messageButton.Text = "Display Message";
            messageButton.UseVisualStyleBackColor = true;
            messageButton.Click += messageButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(80, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = ":0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(175, 83);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 161);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(messageButton);
            Name = "Form1";
            Text = "My First Application";
            ResumeLayout(false);
        }

        #endregion

        private Button messageButton;
        private Button button1;
        private Button button2;
    }
}
