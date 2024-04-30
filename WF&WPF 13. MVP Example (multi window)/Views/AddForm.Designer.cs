namespace WF_WPF_13._MVP_Example__multi_window_
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cancelButton = new Button();
            addButton = new Button();
            idTextBox = new TextBox();
            scheduleTextBox = new TextBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 221);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(113, 23);
            cancelButton.TabIndex = 0;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(131, 221);
            addButton.Name = "addButton";
            addButton.Size = new Size(113, 23);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(12, 12);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(232, 23);
            idTextBox.TabIndex = 1;
            // 
            // scheduleTextBox
            // 
            scheduleTextBox.Location = new Point(12, 41);
            scheduleTextBox.Multiline = true;
            scheduleTextBox.Name = "scheduleTextBox";
            scheduleTextBox.Size = new Size(232, 165);
            scheduleTextBox.TabIndex = 2;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 263);
            Controls.Add(scheduleTextBox);
            Controls.Add(idTextBox);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button addButton;
        private TextBox idTextBox;
        private TextBox scheduleTextBox;
    }
}