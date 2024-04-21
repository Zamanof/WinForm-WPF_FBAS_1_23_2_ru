using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WF_WPF_08._ListBox___List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> cars = new ObservableCollection<string>() {
            "Toyota",
            "Renault",
            "Vaz",
            "Volvo"
        };
        public MainWindow()
        {
            InitializeComponent();
            CarList.ItemsSource = cars;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cars.Add(carTextBox.Text);
            carTextBox.Clear();
        }
    }
}
