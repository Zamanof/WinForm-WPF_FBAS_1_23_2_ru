namespace WF_WPF_03._Dialogs
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
            colorDialogButton = new Button();
            colorLabel = new Label();
            fontDialogButton = new Button();
            fontLabel = new Label();
            folderButton = new Button();
            folderLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // colorDialogButton
            // 
            colorDialogButton.Location = new Point(25, 31);
            colorDialogButton.Name = "colorDialogButton";
            colorDialogButton.Size = new Size(100, 37);
            colorDialogButton.TabIndex = 0;
            colorDialogButton.Text = "Color";
            colorDialogButton.UseVisualStyleBackColor = true;
            colorDialogButton.Click += colorDialogButton_Click;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(25, 82);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(0, 15);
            colorLabel.TabIndex = 1;
            // 
            // fontDialogButton
            // 
            fontDialogButton.Location = new Point(153, 31);
            fontDialogButton.Name = "fontDialogButton";
            fontDialogButton.Size = new Size(100, 37);
            fontDialogButton.TabIndex = 0;
            fontDialogButton.Text = "Font";
            fontDialogButton.UseVisualStyleBackColor = true;
            fontDialogButton.Click += fontDialogButton_Click;
            // 
            // fontLabel
            // 
            fontLabel.AutoSize = true;
            fontLabel.Location = new Point(153, 82);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new Size(77, 15);
            fontLabel.TabIndex = 2;
            fontLabel.Text = "Lorem Ipsum";
            // 
            // folderButton
            // 
            folderButton.Location = new Point(278, 31);
            folderButton.Name = "folderButton";
            folderButton.Size = new Size(100, 37);
            folderButton.TabIndex = 0;
            folderButton.Text = "FolderBrowser";
            folderButton.UseVisualStyleBackColor = true;
            folderButton.Click += folderButton_Click;
            // 
            // folderLabel
            // 
            folderLabel.AutoSize = true;
            folderLabel.Location = new Point(278, 82);
            folderLabel.Name = "folderLabel";
            folderLabel.Size = new Size(0, 15);
            folderLabel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(397, 31);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 0;
            button1.Text = "OpenFile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 410);
            Controls.Add(folderLabel);
            Controls.Add(fontLabel);
            Controls.Add(colorLabel);
            Controls.Add(button1);
            Controls.Add(folderButton);
            Controls.Add(fontDialogButton);
            Controls.Add(colorDialogButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button colorDialogButton;
        private Label colorLabel;
        private Button fontDialogButton;
        private Label fontLabel;
        private Button folderButton;
        private Label folderLabel;
        private Button button1;
    }
}