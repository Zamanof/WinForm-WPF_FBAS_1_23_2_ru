using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace WF_WPF_10._Binding_Element_And_Property
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {       
        public event PropertyChangedEventHandler? PropertyChanged;
        
        private string? _bindedText;
        public string BindedText
        {
            get { return _bindedText!; }
            set { 
                _bindedText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BindedText)));
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

        }

        private void MessageboxButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(BindedText);
        }
        private void RandomTextButtonClick(object sender, RoutedEventArgs e)
        {
            BindedText = Guid.NewGuid().ToString();
        }
    }
}
