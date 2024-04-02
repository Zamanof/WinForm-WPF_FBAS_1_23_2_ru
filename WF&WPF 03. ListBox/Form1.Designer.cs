namespace WF_WPF_03._ListBox
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
            myListBox = new ListBox();
            addTextBox = new TextBox();
            addButton = new Button();
            selectButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // myListBox
            // 
            myListBox.FormattingEnabled = true;
            myListBox.ItemHeight = 15;
            myListBox.Location = new Point(12, 12);
            myListBox.Name = "myListBox";
            myListBox.SelectionMode = SelectionMode.MultiExtended;
            myListBox.Size = new Size(348, 394);
            myListBox.TabIndex = 0;
            myListBox.SelectedIndexChanged += myListBox_SelectedIndexChanged;
            // 
            // addTextBox
            // 
            addTextBox.Location = new Point(12, 415);
            addTextBox.Name = "addTextBox";
            addTextBox.Size = new Size(115, 23);
            addTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(133, 415);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(214, 415);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(68, 23);
            selectButton.TabIndex = 3;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(288, 415);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(68, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 450);
            Controls.Add(deleteButton);
            Controls.Add(selectButton);
            Controls.Add(addButton);
            Controls.Add(addTextBox);
            Controls.Add(myListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox myListBox;
        private TextBox addTextBox;
        private Button addButton;
        private Button selectButton;
        private Button deleteButton;
    }
}