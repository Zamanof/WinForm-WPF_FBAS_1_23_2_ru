namespace WF_WPF_13._Logbook_WF__MVP_
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
            teacherIdTetxtBox = new TextBox();
            clickButton = new Button();
            lessonsListBox = new ListBox();
            SuspendLayout();
            // 
            // teacherIdTetxtBox
            // 
            teacherIdTetxtBox.Location = new Point(12, 12);
            teacherIdTetxtBox.Name = "teacherIdTetxtBox";
            teacherIdTetxtBox.Size = new Size(151, 23);
            teacherIdTetxtBox.TabIndex = 0;
            // 
            // clickButton
            // 
            clickButton.Location = new Point(180, 12);
            clickButton.Name = "clickButton";
            clickButton.Size = new Size(110, 23);
            clickButton.TabIndex = 1;
            clickButton.Text = "Click";
            clickButton.UseVisualStyleBackColor = true;
            clickButton.Click += clickButton_Click;
            // 
            // lessonsListBox
            // 
            lessonsListBox.FormattingEnabled = true;
            lessonsListBox.ItemHeight = 15;
            lessonsListBox.Location = new Point(12, 53);
            lessonsListBox.Name = "lessonsListBox";
            lessonsListBox.Size = new Size(278, 259);
            lessonsListBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 325);
            Controls.Add(lessonsListBox);
            Controls.Add(clickButton);
            Controls.Add(teacherIdTetxtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teacherIdTetxtBox;
        private Button clickButton;
        private ListBox lessonsListBox;
    }
}