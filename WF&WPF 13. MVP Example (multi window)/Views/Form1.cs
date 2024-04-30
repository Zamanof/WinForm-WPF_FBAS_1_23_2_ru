using WF_WPF_13._MVP_Example__multi_window_.Models.Entities;
using WF_WPF_13._MVP_Example__multi_window_.Views.ViewEventArgs;
using WF_WPF_13._MVP_Example__multi_window_.Views.ViewInterfaces;

namespace WF_WPF_13._MVP_Example__multi_window_
{
    public partial class MainForm : Form, IScheduleView
    {
        public MainForm()
        {
            InitializeComponent();
            addButton.Click += AddButton_Click;
            showButton.Click += ShowButton_Click;
        }

        private void ShowButton_Click(object? sender, EventArgs e)
        {
            int.TryParse(teacherIdTextBox.Text, out int id);
            ShowScheduleCalled?.Invoke(this, new ScheduleShowEventArgs(id));
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            AddScheduleCalled?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler<ScheduleShowEventArgs> ShowScheduleCalled;
        public event EventHandler<EventArgs> AddScheduleCalled;

        public void ClearTeacherIdEntry()
        {
            teacherIdTextBox.Clear();
        }

        public void ShowSchedule(Lesson[] lessons)
        {
            lessonsListBox.DataSource = lessons.Select(l => $"Time: {l.Time}   Subject: {l.Subject}  GroupName: {l.Group}").ToList();
        }
    }
}