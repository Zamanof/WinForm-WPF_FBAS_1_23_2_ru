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

namespace WF_WPF_10._Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string? BindedText { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Binding binding = new Binding(nameof(BindedText));
            myTextBox.SetBinding(TextBox.TextProperty, binding);
        }

        //private void myTextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    myLabel.Content = myTextBox.Text;
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BindedText);
        }
    }
}
