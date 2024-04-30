namespace WF_WPF_13._MVP_Example__multi_window_
{
    partial class MainForm
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
            lessonsListBox = new ListBox();
            teacherIdTextBox = new TextBox();
            showButton = new Button();
            addButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lessonsListBox
            // 
            lessonsListBox.FormattingEnabled = true;
            lessonsListBox.ItemHeight = 15;
            lessonsListBox.Location = new Point(12, 12);
            lessonsListBox.Name = "lessonsListBox";
            lessonsListBox.Size = new Size(379, 289);
            lessonsListBox.TabIndex = 0;
            // 
            // teacherIdTextBox
            // 
            teacherIdTextBox.Location = new Point(78, 310);
            teacherIdTextBox.Name = "teacherIdTextBox";
            teacherIdTextBox.Size = new Size(127, 23);
            teacherIdTextBox.TabIndex = 1;
            // 
            // showButton
            // 
            showButton.Location = new Point(225, 310);
            showButton.Name = "showButton";
            showButton.Size = new Size(75, 23);
            showButton.TabIndex = 2;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(316, 310);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 315);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Teacher Id";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 344);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(showButton);
            Controls.Add(teacherIdTextBox);
            Controls.Add(lessonsListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Schedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lessonsListBox;
        private TextBox teacherIdTextBox;
        private Button showButton;
        private Button addButton;
        private Label label1;
    }
}