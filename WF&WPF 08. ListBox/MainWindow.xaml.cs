using System;
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

namespace WF_WPF_08._ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (TextBlock)CarsList.SelectedItem;
            MessageBox.Show(item.Text, "Car selection");
        }

        private void StudentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(StudentList.SelectedItem.ToString(), "Students");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CarsList.Items.Add(new TextBlock { Text = carTextBox.Text });
            carTextBox.Text = String.Empty;
        }

        private void CarsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var items = CarsList.SelectedItems;
                foreach (var item in items)
                {
                    MessageBox.Show(((TextBlock)item).Text, "Car selection");
                }
            }

        }
    }
}
