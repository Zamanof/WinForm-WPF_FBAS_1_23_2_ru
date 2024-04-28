using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WF_WPF_12._Logbook__MVP_WPF_.Models.Entities;
using WF_WPF_12._Logbook__MVP_WPF_.Presenters.Interfaces;

namespace WF_WPF_12._Logbook__MVP_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IScheduleView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public event EventHandler<int>? ShowScheduleCalled = null;

        public void ShowSchedule(ICollection dataSource)
        {
            lessonListBox.ItemsSource = dataSource;
        }
        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(teacherIdTextBox.Text, out int teacherId);
            ShowScheduleCalled?.Invoke(this, teacherId);
        }
    }
}
