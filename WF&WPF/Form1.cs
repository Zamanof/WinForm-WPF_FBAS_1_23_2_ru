namespace WF_WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newWindowButton_Click(object sender, EventArgs e)
        {
            //Form form2 = new Form();
            //form2.ShowDialog();
            Form2 form2 = new Form2(textBox1.Text);
            form2.OtherText = textBox1.Text;
            form2.someMethod(textBox1.Text);
            form2.ShowDialog(textBox1.Text);
        }
    }

}