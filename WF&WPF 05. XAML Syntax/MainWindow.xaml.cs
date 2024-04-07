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

namespace WF_WPF_05._XAML_Syntax
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Button button = new Button()
            //{
            //    Width = 200,
            //    Height = 70,
            //    FontSize = 40,
            //    Background = new SolidColorBrush
            //    {
            //        Color = Colors.Chocolate,
            //        Opacity = 0.5
            //    },
            //    Content = "Click Me"
            //};
            //MyGrid.Children.Add(button);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}