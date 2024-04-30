using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_WPF_13._MVP_Example__multi_window_.Models.Entities;
using WF_WPF_13._MVP_Example__multi_window_.Views.ViewEventArgs;
using WF_WPF_13._MVP_Example__multi_window_.Views.ViewInterfaces;

namespace WF_WPF_13._MVP_Example__multi_window_
{
    public partial class AddForm : Form, IAddScheduleView
    {
        public AddForm()
        {
            InitializeComponent();
            addButton.Click += AddButton_Click;
            cancelButton.Click += CancelButton_Click;
            this.FormClosing += AddForm_FormClosing;

        }

        private void AddForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ViewClosing.Invoke(this, EventArgs.Empty);
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            ViewClosing.Invoke(this, EventArgs.Empty);
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            var schedule = new Schedule
            {
                Id = int.Parse(idTextBox.Text),
                Lessons = scheduleTextBox.Text.Split('\n').Select(line =>
                {
                    var data = line.Split(";").Select(s => s.Trim()).ToArray();
                    return new Lesson
                    {
                        Subject = data[0],
                        Time = data[1],
                        Group = data[2]
                    };
                }).ToArray()
            };
            AddScheduleCalled.Invoke(this, new ScheduleAddEventArgs(schedule));
            this.Close();
        }

        public event EventHandler<ScheduleAddEventArgs> AddScheduleCalled;
        public event EventHandler ViewClosing;

        void IAddScheduleView.ShowDialog()
        {
            ShowDialog();
        }
    }
}
