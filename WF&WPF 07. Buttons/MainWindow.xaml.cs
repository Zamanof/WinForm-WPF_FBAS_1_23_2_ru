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

namespace WF_WPF_07._Buttons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        uint count = 0; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Content not found","Find");
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            count++;
            countTextBlock.Text = count.ToString();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var chekcBox = (CheckBox)sender;
            MessageBox.Show(chekcBox.Content.ToString(), "Chek box");

        }
    }
}
