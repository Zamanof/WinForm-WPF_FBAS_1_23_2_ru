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

namespace WF_WPF_17._EventSetter
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
        private void MouseEnterHandler(object sender, MouseEventArgs e) 
        {
            (sender as TextBlock)!.Background = new SolidColorBrush(Colors.Blue);
        }
        private void MouseLeaveHandler(object sender, MouseEventArgs e)
        {
            (sender as TextBlock)!.Background = new SolidColorBrush(Colors.Red);
        }
    }
}
