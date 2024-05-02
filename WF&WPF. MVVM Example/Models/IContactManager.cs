using System;
using System.Collections.Generic;

namespace WF_WPF._MVVM_Example.Models;

internal interface IContactManager
{
    IEnumerable<Contact> Contacts { get; }

    event EventHandler<ContactEventArgs> ContactAdded;
    event EventHandler<ContactEventArgs> ContactDeleted;

    void AddContact(Contact contact);
    void DeleteContact(Contact contact);
    void UpdateContact(Contact contact);

}
