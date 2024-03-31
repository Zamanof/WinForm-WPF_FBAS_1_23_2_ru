using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace WF_WPF_02._RichTextBox__MaskedTextBox__ComboBox
{
    public partial class Form1 : Form
    {
        List<string> fruits = new List<string>() { "apple", "pear", "ananas", "banana" };

        public Form1()
        {
            InitializeComponent();
            //for (int i = 0; i < fruits.Count; i++)
            //{
            //    fruitsComboBox.Items.Add(fruits[i]);
            //}
            //fruitsComboBox.Text = fruitsComboBox.Items[0].ToString();
            fruitsComboBox.DataSource = fruits;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            var size = richTextBox1.SelectionFont.Size;
            richTextBox1.SelectionFont = new Font("Segoe UI", ++size, FontStyle.Regular);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            var size = richTextBox1.SelectionFont.Size;
            richTextBox1.SelectionFont = new Font("Segoe UI", --size, FontStyle.Regular);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelected.Text = comboBox1.Text;
        }

        private void addComboBoxButton_Click(object sender, EventArgs e)
        {
            fruits.Add(addTextBox.Text);
            fruitsComboBox.DataSource = null;
            fruitsComboBox.DataSource = fruits;
            addTextBox.Clear();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
        }
    }
}