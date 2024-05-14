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

namespace WF_WPF_17._Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool check = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            var border = new Border();
            border.BorderThickness = new Thickness(5, 5, 5, 5);
            border.CornerRadius = new CornerRadius(10, 30, 10, 30);
            border.Width = 150;
            border.Padding = new Thickness(15);
            WrapPanel wrap = new WrapPanel();
            TextBlock text = new TextBlock();
            text.TextWrapping = TextWrapping.Wrap;
            text.Foreground = Brushes.Black;
            text.FontWeight = FontWeights.Bold;
            if(check && txtBox.Text.Length != 0) 
            {
                border.Margin = new Thickness(180, 3, 3, 3);
                border.Background = Brushes.Yellow;
                check = false;
                text.Text += txtBox.Text + $"\n\t{DateTime.Now.ToString("HH:mm")}";
                wrap.Children.Add(text);
                border.Child = wrap;
                panel1.Children.Add(border);
                txtBox.Clear();
            }
            else
            {
                border.Margin = new Thickness(-180, 3, 3, 3);
                border.Background = Brushes.Red;
                check = true;
                text.Text += txtBox.Text + $"\n\t{DateTime.Now.ToString("HH:mm")}";
                wrap.Children.Add(text);
                border.Child = wrap;
                panel1.Children.Add(border);
                txtBox.Clear();
            }
        }
    }
}
