namespace WF_WPF
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
            newWindowButton = new Button();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // newWindowButton
            // 
            newWindowButton.Location = new Point(121, 107);
            newWindowButton.Name = "newWindowButton";
            newWindowButton.Size = new Size(137, 43);
            newWindowButton.TabIndex = 0;
            newWindowButton.Text = "Open window";
            newWindowButton.UseVisualStyleBackColor = true;
            newWindowButton.Click += newWindowButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 188);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 236);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(newWindowButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newWindowButton;
        private TextBox textBox1;
        private RadioButton radioButton1;
    }
}