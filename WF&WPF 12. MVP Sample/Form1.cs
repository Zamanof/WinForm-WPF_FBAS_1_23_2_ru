namespace WF_WPF_12._MVP_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event EventHandler? SomeEvent;
        private void clickButton_Click(object sender, EventArgs e)
        {
            SomeEvent?.Invoke(sender, e);
        }
    }
}