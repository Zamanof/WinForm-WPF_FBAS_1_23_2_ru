namespace WF_WPF_01._First_programm;

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
        changeColorButton = new Button();
        LoginTextBox = new TextBox();
        LoginLabel = new Label();
        PassTextBox = new TextBox();
        PasswordLabel = new Label();
        LoginButton = new Button();
        changeTextBox = new TextBox();
        Changelabel = new Label();
        MouseXLabel = new Label();
        MouseYLabel = new Label();
        DialogResultLabel = new Label();
        dialogButton = new Button();
        SuspendLayout();
        // 
        // changeColorButton
        // 
        changeColorButton.BackColor = Color.Red;
        changeColorButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        changeColorButton.ForeColor = Color.White;
        changeColorButton.Location = new Point(43, 49);
        changeColorButton.Name = "changeColorButton";
        changeColorButton.Size = new Size(116, 39);
        changeColorButton.TabIndex = 0;
        changeColorButton.Text = "Click me";
        changeColorButton.UseVisualStyleBackColor = false;
        changeColorButton.Click += changeColorButton_Click;
        // 
        // LoginTextBox
        // 
        LoginTextBox.Location = new Point(379, 27);
        LoginTextBox.Name = "LoginTextBox";
        LoginTextBox.Size = new Size(116, 23);
        LoginTextBox.TabIndex = 1;
        // 
        // LoginLabel
        // 
        LoginLabel.AutoSize = true;
        LoginLabel.Location = new Point(319, 35);
        LoginLabel.Name = "LoginLabel";
        LoginLabel.Size = new Size(37, 15);
        LoginLabel.TabIndex = 2;
        LoginLabel.Text = "Login";
        // 
        // PassTextBox
        // 
        PassTextBox.Location = new Point(379, 65);
        PassTextBox.Name = "PassTextBox";
        PassTextBox.PasswordChar = '*';
        PassTextBox.Size = new Size(116, 23);
        PassTextBox.TabIndex = 3;
        // 
        // PasswordLabel
        // 
        PasswordLabel.AutoSize = true;
        PasswordLabel.Location = new Point(316, 73);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(57, 15);
        PasswordLabel.TabIndex = 2;
        PasswordLabel.Text = "Password";
        // 
        // LoginButton
        // 
        LoginButton.Location = new Point(420, 105);
        LoginButton.Name = "LoginButton";
        LoginButton.Size = new Size(75, 23);
        LoginButton.TabIndex = 4;
        LoginButton.Text = "Sign In";
        LoginButton.UseVisualStyleBackColor = true;
        LoginButton.Click += LoginButton_Click;
        // 
        // changeTextBox
        // 
        changeTextBox.Location = new Point(12, 194);
        changeTextBox.Name = "changeTextBox";
        changeTextBox.Size = new Size(100, 23);
        changeTextBox.TabIndex = 5;
        changeTextBox.TextChanged += changeTextBox_TextChanged;
        changeTextBox.KeyDown += Form1_KeyDown;
        // 
        // Changelabel
        // 
        Changelabel.AutoSize = true;
        Changelabel.Location = new Point(19, 232);
        Changelabel.Name = "Changelabel";
        Changelabel.Size = new Size(0, 15);
        Changelabel.TabIndex = 6;
        // 
        // MouseXLabel
        // 
        MouseXLabel.AutoSize = true;
        MouseXLabel.Location = new Point(356, 202);
        MouseXLabel.Name = "MouseXLabel";
        MouseXLabel.Size = new Size(26, 15);
        MouseXLabel.TabIndex = 7;
        MouseXLabel.Text = "X: 0";
        // 
        // MouseYLabel
        // 
        MouseYLabel.AutoSize = true;
        MouseYLabel.Location = new Point(356, 232);
        MouseYLabel.Name = "MouseYLabel";
        MouseYLabel.Size = new Size(26, 15);
        MouseYLabel.TabIndex = 7;
        MouseYLabel.Text = "Y: 0";
        // 
        // DialogResultLabel
        // 
        DialogResultLabel.AutoSize = true;
        DialogResultLabel.Location = new Point(315, 306);
        DialogResultLabel.Name = "DialogResultLabel";
        DialogResultLabel.Size = new Size(38, 15);
        DialogResultLabel.TabIndex = 8;
        DialogResultLabel.Text = "label1";
        // 
        // dialogButton
        // 
        dialogButton.Location = new Point(298, 342);
        dialogButton.Name = "dialogButton";
        dialogButton.Size = new Size(75, 23);
        dialogButton.TabIndex = 9;
        dialogButton.Text = "Click";
        dialogButton.UseVisualStyleBackColor = true;
        dialogButton.Click += dialogButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(677, 418);
        Controls.Add(dialogButton);
        Controls.Add(DialogResultLabel);
        Controls.Add(MouseYLabel);
        Controls.Add(MouseXLabel);
        Controls.Add(Changelabel);
        Controls.Add(changeTextBox);
        Controls.Add(LoginButton);
        Controls.Add(PassTextBox);
        Controls.Add(PasswordLabel);
        Controls.Add(LoginLabel);
        Controls.Add(LoginTextBox);
        Controls.Add(changeColorButton);
        Name = "Form1";
        Text = "My first program ";
        KeyDown += Form1_KeyDown;
        MouseLeave += Form1_MouseLeave;
        MouseMove += Form1_MouseMove;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button changeColorButton;
    private TextBox LoginTextBox;
    private Label LoginLabel;
    private TextBox PassTextBox;
    private Label PasswordLabel;
    private Button LoginButton;
    private TextBox changeTextBox;
    private Label Changelabel;
    private Label MouseXLabel;
    private Label MouseYLabel;
    private Label DialogResultLabel;
    private Button dialogButton;
}
