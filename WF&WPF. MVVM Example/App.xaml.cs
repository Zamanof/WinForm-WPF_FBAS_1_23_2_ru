using System.Windows;
using WF_WPF._MVVM_Example.Models;
using WF_WPF._MVVM_Example.ViewModels;
using WF_WPF._MVVM_Example.Views;

namespace WF_WPF._MVVM_Example;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
internal sealed partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var contactManager = new ContactManger();
        var phoneCodeManger = new PhoneCodeManager();
        var viewModelFactory = new ViewModelFactory(phoneCodeManger);

        var viewModel = new MainViewModel(contactManager, phoneCodeManger, viewModelFactory);
        var view = new MainView(viewModel);
        view.Show();
    }
}
