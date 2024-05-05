using System;
using System.ComponentModel;
using System.Windows.Input;
using WF_WPF._MVVM_Example;
using WF_WPF._MVVM_Example.Models;
using WF_WPF._MVVM_Example.ViewModels;

internal sealed class ContactViewModel : ViewModel<ContactViewModel>
{

    private readonly Contact contact;
    private readonly ICommand deleteCommand;
    private readonly ICommand editCommand;
    private readonly IPhoneCodeManager phoneCodeManager;

    public ContactViewModel(Contact contact, IPhoneCodeManager phoneCodeManager)
    {
        this.contact = contact;
        this.phoneCodeManager = phoneCodeManager;
        deleteCommand = new DelegateCommand(Delete);
        editCommand = new DelegateCommand(Edit);

        contact.EmailChanged += Contact_EmailChanged;
        contact.PhoneChanged += Contact_PhoneChanged;
        contact.PhoneCodeChanged += Contact_PhoneCodeChanged;

    }

    [DependsUpon(nameof(Phone))]
    public string Area => phoneCodeManager.GetAreaByPhoneCode(contact.PhoneCode);

    public ICommand DeleteCommand => deleteCommand;
    public ICommand EditCommand => editCommand;
    public string Email => contact.Email.ToLower();
    public Guid Id => contact.Id;
    public string Name => $"{contact.FirstName} {contact.LastName}";

    public string Phone => $"({contact.PhoneCode}) {contact.Phone.Substring(0, 3)}-{contact.Phone.Substring(3, 4)}";

    public event EventHandler<ContactEventArgs> DeleteRequested;
    public event EventHandler<ContactEventArgs> EditRequested;

    private void Contact_PhoneCodeChanged(object? sender, EventArgs e)
    {
        OnPropertyChanged(new PropertyChangedEventArgs(nameof(Phone)));
    }

    private void Contact_PhoneChanged(object? sender, EventArgs e)
    {
        OnPropertyChanged(new PropertyChangedEventArgs(nameof(Phone)));
    }

    private void Contact_EmailChanged(object? sender, EventArgs e)
    {
        OnPropertyChanged(new PropertyChangedEventArgs(nameof(Email)));
    }

    private void Edit()
    {
        OnEditRequested(new ContactEventArgs(contact));
    }

    private void OnEditRequested(ContactEventArgs contactEvent)
    {
        EditRequested.Invoke(this, contactEvent);
    }

    private void Delete()
    {
        OnDeleteRequested(new ContactEventArgs(contact));
    }

    private void OnDeleteRequested(ContactEventArgs contactEvent)
    {
        DeleteRequested.Invoke(this, contactEvent);
    }
}