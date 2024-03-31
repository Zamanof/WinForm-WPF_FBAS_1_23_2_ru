using System.Text;

namespace WF_WPF_01._CheckBox___RadioButton
{
    public partial class Form1 : Form
    {
        public List<string> languages = new List<string>();
        public Form1()
        {
            InitializeComponent();
            //pythonCheckBox.Checked = true;
            //pythonCheckBox.CheckState = CheckState.Indeterminate;

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var anyCheckBox = (CheckBox)sender;
            if (anyCheckBox.Checked == true)
            {
                anyCheckBox.ForeColor = Color.Red;
                anyCheckBox.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            else
            {
                anyCheckBox.ForeColor = Color.Black;
                anyCheckBox.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
            if (anyCheckBox.Text == "Python" && anyCheckBox.Checked == true)
            {
                languages.Add(anyCheckBox.Text);
            }
            else if (anyCheckBox.Text == "Python" && anyCheckBox.Checked == false)
            {
                languages.Remove("Python");
            }
            if (anyCheckBox.Text == "C++" && anyCheckBox.Checked == true)
            {
                languages.Add(anyCheckBox.Text);
            }
            else if (anyCheckBox.Text == "C++" && anyCheckBox.Checked == false)
            {
                languages.Remove("C++");
            }
            for (int i = 0; i < languages.Count; i++)
            {
                stringBuilder.Append(languages[i] + " ");
            }
            languagesLabel.Text = stringBuilder.ToString();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rButton = (RadioButton)sender;
            if (rButton.Checked == true)
            {
                rButton.ForeColor = Color.Blue;
            }
            else { rButton.ForeColor = Color.Black; }
        }

        private void gSelectButton_Click(object sender, EventArgs e)
        {
            if (maleRadioButton.Checked == true)
            {
                BackColor = Color.AliceBlue;
            }
            else if (femaleRadioButton.Checked == true)
            {
                BackColor = Color.Pink;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}