namespace WF_WPF_04._Timer_and_ProgressBar
{
    public partial class Form1 : Form
    {
        int number = 0;
        int tick = 0;
        int name = 1;
        public Form1()
        {
            InitializeComponent();
            //timer2.Tick += changeColor;
            timer2.Start();
            Button button = new Button();
            button.Text = "Dynamic";
            button.Location = new Point(500, 200);
            button.Click += startButton_Click;
            Controls.Add(button);

        }

        private void changeColor(object sender, EventArgs e)
        {
            switch (tick % 3)
            {
                case 0:
                    BackColor = Color.Red;
                    break;
                case 1:
                    BackColor = Color.Green;
                    break;
                case 2:
                    BackColor = Color.Blue;
                    break;
            }
            tick++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = number.ToString();
            ++number;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer3.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar2.PerformStep();

            if (progressBar2.Value >= 100)
            {
                timer3.Stop();
                MessageBox.Show("Download finish");
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.Location = new Point(e.X, e.Y);
            button.Text = name++.ToString();
            Controls.Add(button);
        }
    }
}