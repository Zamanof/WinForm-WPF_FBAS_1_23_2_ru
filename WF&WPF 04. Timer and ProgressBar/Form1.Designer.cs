namespace WF_WPF_04._Timer_and_ProgressBar
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            startButton = new Button();
            endButton = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            numericUpDown1 = new NumericUpDown();
            progressBar2 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            timer3 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 52);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // startButton
            // 
            startButton.Location = new Point(29, 96);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // endButton
            // 
            endButton.Location = new Point(126, 96);
            endButton.Name = "endButton";
            endButton.Size = new Size(75, 23);
            endButton.TabIndex = 1;
            endButton.Text = "End";
            endButton.UseVisualStyleBackColor = true;
            endButton.Click += endButton_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(322, 54);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(233, 23);
            progressBar1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(322, 98);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(144, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // progressBar2
            // 
            progressBar2.ForeColor = Color.FromArgb(192, 0, 0);
            progressBar2.Location = new Point(29, 210);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(233, 23);
            progressBar2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(29, 263);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(126, 263);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "End";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(endButton);
            Controls.Add(button1);
            Controls.Add(startButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button startButton;
        private Button endButton;
        private System.Windows.Forms.Timer timer2;
        private ProgressBar progressBar1;
        private NumericUpDown numericUpDown1;
        private ProgressBar progressBar2;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer3;
    }
}