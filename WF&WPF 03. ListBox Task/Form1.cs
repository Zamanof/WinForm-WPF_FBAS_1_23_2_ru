using System.Windows.Forms;

namespace WF_WPF_03._ListBox_Task
{
    public partial class Form1 : Form
    {
        public List<string> LeftList { get; set; } = new List<string> {
         "Mazda", "Audi", "BMW", "Mercedes"
        };
        public List<string> RightList { get; set; } = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = LeftList;
            listBox2.DataSource = RightList;
            button2.Enabled = false;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                RightList.Add(listBox1.SelectedItem.ToString());
                LeftList.Remove(listBox1.SelectedItem.ToString());
                if (RightList.Count > 0) { button2.Enabled = true; }
                if (LeftList.Count == 0) { rightButton.Enabled = false; }
                updateListSource();
            }

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                LeftList.Add(listBox2.SelectedItem.ToString());
                RightList.Remove(listBox2.SelectedItem.ToString());
                if (RightList.Count == 0) { button2.Enabled = false; }
                if (LeftList.Count > 0) { rightButton.Enabled = true; }
                updateListSource();
            }

        }

        private void updateListSource()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = LeftList;
            listBox2.DataSource = RightList;
        }
    }
}