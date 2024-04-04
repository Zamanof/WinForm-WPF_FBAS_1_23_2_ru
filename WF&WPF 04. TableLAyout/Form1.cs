namespace WF_WPF_04._TableLAyout
{
    public partial class Form1 : Form
    {
        //List<Button> buttons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int ind = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Text = $"{i}{j}";
                    //buttons.Add(button);
                    tableLayoutPanel1.Controls.Add(button);
                    
                    //buttons[ind].Dock = DockStyle.Fill;
                    button.Dock = DockStyle.Fill;
                    tableLayoutPanel1.SetCellPosition(button, new TableLayoutPanelCellPosition(i, j));
                }
            }
        }
    }
}