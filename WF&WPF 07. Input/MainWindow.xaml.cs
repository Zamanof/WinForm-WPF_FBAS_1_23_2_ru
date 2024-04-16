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

namespace WF_WPF_07._Input
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myTextBlock.Text = myTextBox.Text;
            myTextBox.Text = String.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            myTextBlock.Text = myTextBox.SelectedText;
        }

        private void myTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            myTextBox.Text = String.Empty;
        }

        private void myTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            changedTextBlock.Text = myTextBox.Text;
        }
    }
}
