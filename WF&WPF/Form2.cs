using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_WPF
{
    public partial class Form2 : Form
    {
        public string OtherText { get; set; }
        public Form2(string text)
        {
            InitializeComponent();
            label1.Text = text;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = OtherText;
        }
        public void someMethod(string text)
        {
            label2.Text = text;
        }
        
        public DialogResult ShowDialog(string text)
        {
            button1.Text = text;
            return ShowDialog();
        }
    }
}
