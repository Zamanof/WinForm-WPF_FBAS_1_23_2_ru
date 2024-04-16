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

namespace WF_WPF_07._Media
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyVideo.Source = new Uri(@"C:\Users\zamanov\source\repos\WinForm-WPF_FBAS_1_23_2_ru\WF&WPF 07. Media\All Puskas Award Winners (2009-2021).mp4");
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
