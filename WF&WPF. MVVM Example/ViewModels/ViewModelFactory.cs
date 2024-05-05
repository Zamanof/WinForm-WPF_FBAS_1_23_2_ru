using WF_WPF._MVVM_Example.Models;

namespace WF_WPF._MVVM_Example.ViewModels;

class ViewModelFactory : IViewModelFactory
{
    private readonly IPhoneCodeManager phoneCodeManager;

    public ViewModelFactory(IPhoneCodeManager phoneCodeManager)
    {
        this.phoneCodeManager = phoneCodeManager;
    }

    public ContactViewModel CreateContactViewModel(Contact contact)
    {
       return new ContactViewModel(contact, phoneCodeManager);
    }
}
