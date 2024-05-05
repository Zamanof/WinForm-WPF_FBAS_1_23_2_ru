using WF_WPF._MVVM_Example.Models;

namespace WF_WPF._MVVM_Example.ViewModels;

interface IViewModelFactory
{
    ContactViewModel CreateContactViewModel(Contact contact);
}
