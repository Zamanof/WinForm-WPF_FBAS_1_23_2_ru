using System;

namespace WF_WPF._MVVM_Example.Models;

internal sealed class ContactEventArgs: EventArgs
{
    private readonly Contact _contact;
    public Contact Contact => _contact;

    public ContactEventArgs(Contact contact)
    {
        _contact = contact;
    }
}
