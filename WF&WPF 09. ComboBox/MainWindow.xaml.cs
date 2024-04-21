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

namespace WF_WPF_09._ComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> items = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            SelectedListBox.ItemsSource = items;
            ProgrammingComboBox.Text = (ProgrammingComboBox.Items[0] as ComboBoxItem).Content.ToString();
        }

        private void ProgrammingComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            items.Add((ProgrammingComboBox.SelectedItem as ComboBoxItem).Content.ToString());
            SelectedListBox.Items.Refresh();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ProgrammingItemTextBox.Text != string.Empty)
            {
                ProgrammingComboBox.Items.Add(new ComboBoxItem { Content = ProgrammingItemTextBox.Text });
                ProgrammingItemTextBox.Clear();
            }
        }

        private void ProgrammingComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                bool ch = false;
                foreach (ComboBoxItem item in ProgrammingComboBox.Items)
                {
                    if (item.Content == ProgrammingComboBox.Text)
                    {
                        ch = true;
                        break;
                    }
                }
                if (!ch)
                {
                    ProgrammingComboBox.Items.Add(new ComboBoxItem { Content = ProgrammingComboBox.Text });
                }
                ProgrammingComboBox.Text = string.Empty;
            }
        }
    }
}
