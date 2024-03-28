namespace WF_WPF_01._First_programm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        changeColorButton.Click += Who_Is;
        LoginButton.Click += Who_Is;
        changeTextBox.TextChanged += Who_Is;

    }

    private void Form1_MouseLeave(object sender, EventArgs e)
    {
        //BackColor = Color.BlueViolet;
    }

    private void changeColorButton_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        var r = random.Next(0, 255);
        var g = random.Next(0, 255);
        var b = random.Next(0, 255);
        BackColor = Color.FromArgb(r, g, b);
    }

    private void foo(object sender, EventArgs e)
    {
        Random random = new Random();
        var r = random.Next(0, 255);
        var g = random.Next(0, 255);
        var b = random.Next(0, 255);
        changeColorButton.BackColor = Color.FromArgb(r, g, b);
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        if (LoginTextBox.Text == "Admin" && PassTextBox.Text == "Admin")
        {
            MessageBox.Show("Welcome to application", "Login",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Incorrect login or password", "Login",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
        }
        LoginTextBox.Text = string.Empty;
        PassTextBox.Text = string.Empty;
    }

    private void changeTextBox_TextChanged(object sender, EventArgs e)
    {
        Changelabel.Text = changeTextBox.Text;
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        MouseXLabel.Text = $"X: {e.X}";
        MouseYLabel.Text = $"Y: {e.Y}";
    }

    private void Who_Is(object sender, EventArgs e)
    {
        Button? button = sender as Button;
        TextBox? textBox = sender as TextBox;
        if (button is not null)
        {
            Text = button.Name;
        }
        if (textBox is not null)
        {
            Text = textBox.Text;
        }
    }
}
