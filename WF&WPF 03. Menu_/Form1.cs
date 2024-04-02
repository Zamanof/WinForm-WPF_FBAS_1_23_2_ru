namespace WF_WPF_03._Menu_
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            var result = MessageBox.Show("Are you sure?", "Close window", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.Cancel)
            {                
                e.Cancel = true;
            }
        }
    }
}