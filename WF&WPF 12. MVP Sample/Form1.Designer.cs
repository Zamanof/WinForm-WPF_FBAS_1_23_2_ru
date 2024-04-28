namespace WF_WPF_12._MVP_Sample
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
            clickButton = new Button();
            myTextBox = new TextBox();
            SuspendLayout();
            // 
            // clickButton
            // 
            clickButton.Location = new Point(79, 66);
            clickButton.Name = "clickButton";
            clickButton.Size = new Size(75, 23);
            clickButton.TabIndex = 0;
            clickButton.Text = "Click";
            clickButton.UseVisualStyleBackColor = true;
            clickButton.Click += clickButton_Click;
            // 
            // myTextBox
            // 
            myTextBox.Location = new Point(45, 23);
            myTextBox.Name = "myTextBox";
            myTextBox.Size = new Size(143, 23);
            myTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 104);
            Controls.Add(clickButton);
            Controls.Add(myTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clickButton;
        internal TextBox myTextBox;
    }
}