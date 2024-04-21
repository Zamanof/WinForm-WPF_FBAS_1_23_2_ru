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

namespace WF_WPF_08._ListBox___class
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Car> cars = new ObservableCollection<Car>{
            new Car{ Marka="Toyota", Model="Prius", Year= 2020},
            new Car{ Marka="Toyota", Model="Yaris", Year= 2018},
            new Car{ Marka="Toyota", Model="Carolla", Year= 1980}
        };
        public MainWindow()
        {
            InitializeComponent();
            CarList.ItemsSource = cars;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cars.Add(new Car { Marka = "Toyota", Model = $"{carTextBox.Text}", Year = 1258 });
            carTextBox.Clear();
        }
    }
}
