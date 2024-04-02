namespace WF_WPF_03._Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ColorDialog
            // FolderBrowserDialog
            // FontDialog
            // OpenFileDialog
            // PrintDioalog
            // PrintPreviewDialogd
            // PageSetupDialog
            // SaveFileDialog
        }

        private void colorDialogButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            var R = colorDialog.Color.R;
            var G = colorDialog.Color.G;
            var B = colorDialog.Color.B;
            colorLabel.Text = $"R: {R}, " +
                $"G: {G}, " +
                $"B: {B}";
            //BackColor = Color.FromArgb(R, G, B);
        }

        private void fontDialogButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            fontLabel.Font = fontDialog.Font;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderLabel.Text = folderBrowserDialog.SelectedPath.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files |*.txt|All Files|*.*";
            openFileDialog.ShowDialog();

        }
    }
}