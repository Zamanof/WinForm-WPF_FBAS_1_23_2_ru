
using System.Windows;
using WF_WPF._MVVM_Example.ViewModels;

namespace WF_WPF._MVVM_Example.Views;

internal sealed partial class MainView : Window
{
    public MainView(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
