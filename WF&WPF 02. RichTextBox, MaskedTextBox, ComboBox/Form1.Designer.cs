namespace WF_WPF_02._RichTextBox__MaskedTextBox__ComboBox
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
            maskedTextBox1 = new MaskedTextBox();
            richTextBox1 = new RichTextBox();
            redButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            plusButton = new Button();
            minusButton = new Button();
            comboBox1 = new ComboBox();
            comboBoxSelected = new Label();
            fruitsComboBox = new ComboBox();
            addTextBox = new TextBox();
            addComboBoxButton = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(25, 24);
            maskedTextBox1.Mask = "(+994) 00-000-00-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(123, 23);
            maskedTextBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(210, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(232, 96);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // redButton
            // 
            redButton.Location = new Point(448, 23);
            redButton.Name = "redButton";
            redButton.Size = new Size(75, 23);
            redButton.TabIndex = 2;
            redButton.Text = "Red Text";
            redButton.UseVisualStyleBackColor = true;
            redButton.Click += redButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(208, 130);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Cut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(289, 130);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Copy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(367, 130);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Paste";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(448, 52);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(75, 23);
            plusButton.TabIndex = 3;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // minusButton
            // 
            minusButton.Location = new Point(448, 81);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(75, 23);
            minusButton.TabIndex = 3;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baku", "Kiev", "Ankara", "Tbilisi" });
            comboBox1.Location = new Point(27, 239);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxSelected
            // 
            comboBoxSelected.AutoSize = true;
            comboBoxSelected.Location = new Point(205, 248);
            comboBoxSelected.Name = "comboBoxSelected";
            comboBoxSelected.Size = new Size(0, 15);
            comboBoxSelected.TabIndex = 5;
            // 
            // fruitsComboBox
            // 
            fruitsComboBox.FormattingEnabled = true;
            fruitsComboBox.Location = new Point(174, 308);
            fruitsComboBox.Name = "fruitsComboBox";
            fruitsComboBox.Size = new Size(121, 23);
            fruitsComboBox.TabIndex = 6;
            // 
            // addTextBox
            // 
            addTextBox.Location = new Point(195, 240);
            addTextBox.Name = "addTextBox";
            addTextBox.Size = new Size(100, 23);
            addTextBox.TabIndex = 7;
            // 
            // addComboBoxButton
            // 
            addComboBoxButton.Location = new Point(220, 269);
            addComboBoxButton.Name = "addComboBoxButton";
            addComboBoxButton.Size = new Size(75, 23);
            addComboBoxButton.TabIndex = 8;
            addComboBoxButton.Text = "Add";
            addComboBoxButton.UseVisualStyleBackColor = true;
            addComboBoxButton.Click += addComboBoxButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 251);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Location = new Point(385, 239);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 299);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 369);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(addComboBoxButton);
            Controls.Add(addTextBox);
            Controls.Add(label2);
            Controls.Add(fruitsComboBox);
            Controls.Add(comboBoxSelected);
            Controls.Add(comboBox1);
            Controls.Add(minusButton);
            Controls.Add(plusButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(redButton);
            Controls.Add(richTextBox1);
            Controls.Add(maskedTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private RichTextBox richTextBox1;
        private Button redButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button plusButton;
        private Button minusButton;
        private ComboBox comboBox1;
        private Label comboBoxSelected;
        private ComboBox fruitsComboBox;
        private TextBox addTextBox;
        private Button addComboBoxButton;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label1;
    }
}