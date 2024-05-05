using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WF_WPF._MVVM_Example.Models;

namespace WF_WPF._MVVM_Example.ViewModels;

internal sealed class MainViewModel : ViewModel<MainViewModel>
{
    private readonly ICommand cancelCommand;
    public ICommand CancelCommand => cancelCommand;

    private readonly IContactManager contactManager;

    private readonly ICollection<ContactViewModel> contacts
        = new ObservableCollection<ContactViewModel>();
    public IEnumerable<ContactViewModel> Contacts => contacts;

    private readonly ICommand loadedCommand;
    public ICommand LoadedCommand => loadedCommand;

    private readonly IPhoneCodeManager phoneCodeManager;

    private readonly ICollection<string> phoneCodes
        = new ObservableCollection<string>();
    public ICollection<string> PhoneCodes => phoneCodes;

    private readonly Command saveCommand;
    [CanExecute(nameof(CanSave))]
    public Command SaveCommand => saveCommand;

    private readonly IViewModelFactory viewModelFactory;

    private bool canEditFirstName = true;
    public bool CanEditFirstName
    {
        get => canEditFirstName;
        set => SetProperty(ref canEditFirstName, value);
    }

    private bool canEditLastName = true;
    public bool CanEditLastName
    {
        get => canEditLastName;
        set => SetProperty(ref canEditLastName, value);
    }

    private Contact editContact;
    public Contact EditContact
    {
        get => editContact;
        set => SetProperty(ref editContact, value);
    }

    private string email = string.Empty;
    public string Email
    {
        get=> email; 
        set => SetProperty(ref email, value);
    }


    private string firstName = string.Empty;
    public string FirstName
    {
        get => firstName;
        set => SetProperty(ref firstName, value);
    }

    private string lastName = string.Empty;
    public string LastName
    {
        get=> lastName;
        set => SetProperty(ref lastName, value);
    }

    private string phone = string.Empty;
    public string Phone
    {
        get=> phone;
        set => SetProperty(ref phone, value);
    }

    private string phoneCode;
    public string PhoneCode
    {
        get=> phoneCode;
        set => SetProperty(ref phoneCode, value);
    }

    private ContactViewModel selectedContact;
    public ContactViewModel SelectedContact
    {
        get => selectedContact;
        set => SetProperty(ref selectedContact, value);
    }


    [DependsUpon(nameof(Email))]
    [DependsUpon(nameof(FirstName))]
    [DependsUpon(nameof(LastName))]
    [DependsUpon(nameof(PhoneCode))]
    [DependsUpon(nameof(Phone))]
    public bool CanSave => FirstName.Length > 0 && lastName.Length > 0
        && Email.Length > 0 && Phone.Length == 7 && PhoneCode != null;

    public MainViewModel(IContactManager contactManager, 
        IPhoneCodeManager phoneCodeManager, IViewModelFactory viewModelFactory)
    {
        this.contactManager = contactManager;
        this.phoneCodeManager = phoneCodeManager;
        this.viewModelFactory = viewModelFactory;
        cancelCommand = new DelegateCommand(Cancel);
        loadedCommand = new DelegateCommand(Load);
        saveCommand = new DelegateCommand(Save, ()=>CanSave);

        contactManager.ContactAdded += ContactManager_ContactAdded;
        contactManager.ContactDeleted += ContactManager_ContactDeleted;
    }


    private void ContactManager_ContactDeleted(object? sender, ContactEventArgs e)
    {
        foreach (ContactViewModel contact  in contacts)
        {
            if (contact.Id.Equals(e.Contact.Id))
            {
                contacts.Remove(contact);
                break;
            }
        }
    }

    private void ContactManager_ContactAdded(object? sender, ContactEventArgs e)
    {
       AddContact(e.Contact);
    }

    private void Save()
    {
       Contact contact = EditContact ?? new Contact(FirstName, LastName);
        contact.Email = Email;
        contact.Phone = Phone;
        contact.PhoneCode = PhoneCode;

        if(EditContact is null)
        {
            contactManager.AddContact(contact);
        }
        else
        {
            contactManager.UpdateContact(contact);
        }
    }

    private void Load()
    {
        LoadPhoneCodes();
        LoadContacts();
    }

    private void LoadContacts()
    {
        foreach(Contact contact in contactManager.Contacts)
        {
            AddContact(contact);
        }
    }

    private void LoadPhoneCodes()
    {
        foreach(string phoneCode in phoneCodeManager.PhoneCodes)
        {
            phoneCodes.Add(phoneCode);
        }
    }

    private void LoadSelectedContact()
    {
        Email = EditContact.Email;
        FirstName = EditContact.FirstName;
        LastName = EditContact.LastName;
        Phone = EditContact.Phone;
        PhoneCode = EditContact.PhoneCode;

        CanEditFirstName = false;
        CanEditLastName = false;
    }

    private void Cancel()
    {
        Email = string.Empty;
        Phone = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        PhoneCode = null;

        CanEditFirstName = true;
        CanEditLastName = true;
    }

    private void AddContact(Contact contact)
    {
        ContactViewModel viewModel = viewModelFactory.CreateContactViewModel(contact);
        viewModel.DeleteRequested += ViewModel_DeleteRequested;
        viewModel.EditRequested += ViewModel_EditRequested;
        contacts.Add(viewModel);
    }

    private void ViewModel_EditRequested(object? sender, ContactEventArgs e)
    {
        EditContact = e.Contact;
    }

    private void ViewModel_DeleteRequested(object? sender, ContactEventArgs e)
    {
        contactManager.DeleteContact(e.Contact);
        if (EditContact == e.Contact)
        {
            Cancel();
        }
    }
}
