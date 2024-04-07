using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WF_WPF_05._WPF_Intro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Button button = new Button() {
            //    Content = "Press",
            //    Background = Brushes.Black,
            //    Foreground = Brushes.White,
            //    FontSize = 23,
            //    Width = 150,
            //    Height = 100,
            //};
            //button.Click += Button_Click;
            //MyGrid.Children.Add(button);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Aquamarine;
        }
    }
}