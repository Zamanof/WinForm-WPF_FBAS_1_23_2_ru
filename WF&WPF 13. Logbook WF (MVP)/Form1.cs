using LogbookLibrary;
using System.Collections;

namespace WF_WPF_13._Logbook_WF__MVP_
{
    public partial class Form1 : Form, IScheduleView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event EventHandler<int> ShowScheduleCalled;

        public void ShowSchedule(ICollection lessons)
        {
           lessonsListBox.DataSource = lessons;
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            int.TryParse(teacherIdTetxtBox.Text, out int teacherId);
            ShowScheduleCalled?.Invoke(this, teacherId);
        }
    }
}