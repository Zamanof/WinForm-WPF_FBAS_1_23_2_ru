namespace WF_WPF_04._TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", trackBar1.Value);
        }

        private void TrackBarChange(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(
                redTrackBar.Value,
                greenTrackBar.Value,
                blueTrackBar.Value);
            label2.Text = $"Red: {redTrackBar.Value}";
            label3.Text = $"Green: {greenTrackBar.Value}";
            label4.Text = $"Blue: {blueTrackBar.Value}";

        }


    }
}