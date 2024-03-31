namespace WF_WPF_01._CheckBox___RadioButton
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
            pythonCheckBox = new CheckBox();
            cppCheckBox = new CheckBox();
            label1 = new Label();
            charpTextBox = new CheckBox();
            jsTextBox = new CheckBox();
            languagesLabel = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            gSelectButton = new Button();
            yesRadioButton = new RadioButton();
            noRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pythonCheckBox
            // 
            pythonCheckBox.AutoSize = true;
            pythonCheckBox.Location = new Point(35, 52);
            pythonCheckBox.Name = "pythonCheckBox";
            pythonCheckBox.Size = new Size(64, 19);
            pythonCheckBox.TabIndex = 0;
            pythonCheckBox.Text = "Python";
            pythonCheckBox.UseVisualStyleBackColor = true;
            pythonCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // cppCheckBox
            // 
            cppCheckBox.AutoSize = true;
            cppCheckBox.Location = new Point(35, 77);
            cppCheckBox.Name = "cppCheckBox";
            cppCheckBox.Size = new Size(50, 19);
            cppCheckBox.TabIndex = 0;
            cppCheckBox.Text = "C++";
            cppCheckBox.UseVisualStyleBackColor = true;
            cppCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Languages";
            // 
            // charpTextBox
            // 
            charpTextBox.AutoSize = true;
            charpTextBox.Location = new Point(35, 102);
            charpTextBox.Name = "charpTextBox";
            charpTextBox.Size = new Size(41, 19);
            charpTextBox.TabIndex = 0;
            charpTextBox.Text = "C#";
            charpTextBox.UseVisualStyleBackColor = true;
            charpTextBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // jsTextBox
            // 
            jsTextBox.AutoSize = true;
            jsTextBox.Location = new Point(35, 127);
            jsTextBox.Name = "jsTextBox";
            jsTextBox.Size = new Size(78, 19);
            jsTextBox.TabIndex = 0;
            jsTextBox.Text = "JavaScript";
            jsTextBox.UseVisualStyleBackColor = true;
            jsTextBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // languagesLabel
            // 
            languagesLabel.AutoSize = true;
            languagesLabel.Location = new Point(35, 166);
            languagesLabel.Name = "languagesLabel";
            languagesLabel.Size = new Size(0, 15);
            languagesLabel.TabIndex = 2;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(36, 45);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(51, 19);
            maleRadioButton.TabIndex = 3;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            maleRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(36, 70);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(63, 19);
            femaleRadioButton.TabIndex = 4;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            femaleRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // gSelectButton
            // 
            gSelectButton.Location = new Point(36, 107);
            gSelectButton.Name = "gSelectButton";
            gSelectButton.Size = new Size(75, 23);
            gSelectButton.TabIndex = 6;
            gSelectButton.Text = "Gender Select";
            gSelectButton.UseVisualStyleBackColor = true;
            gSelectButton.Click += gSelectButton_Click;
            // 
            // yesRadioButton
            // 
            yesRadioButton.AutoSize = true;
            yesRadioButton.Location = new Point(16, 34);
            yesRadioButton.Name = "yesRadioButton";
            yesRadioButton.Size = new Size(42, 19);
            yesRadioButton.TabIndex = 7;
            yesRadioButton.TabStop = true;
            yesRadioButton.Text = "Yes";
            yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            noRadioButton.AutoSize = true;
            noRadioButton.Location = new Point(16, 59);
            noRadioButton.Name = "noRadioButton";
            noRadioButton.Size = new Size(41, 19);
            noRadioButton.TabIndex = 7;
            noRadioButton.TabStop = true;
            noRadioButton.Text = "No";
            noRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maleRadioButton);
            groupBox1.Controls.Add(femaleRadioButton);
            groupBox1.Controls.Add(gSelectButton);
            groupBox1.Location = new Point(219, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 144);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(noRadioButton);
            groupBox2.Controls.Add(yesRadioButton);
            groupBox2.Location = new Point(493, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(218, 96);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Age < 18?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 208);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(languagesLabel);
            Controls.Add(label1);
            Controls.Add(jsTextBox);
            Controls.Add(charpTextBox);
            Controls.Add(cppCheckBox);
            Controls.Add(pythonCheckBox);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox pythonCheckBox;
        private CheckBox cppCheckBox;
        private Label label1;
        private CheckBox charpTextBox;
        private CheckBox jsTextBox;
        private Label languagesLabel;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private Button gSelectButton;
        private RadioButton yesRadioButton;
        private RadioButton noRadioButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}