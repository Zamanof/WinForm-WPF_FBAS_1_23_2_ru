using System;

namespace WF_WPF._MVVM_Example.Models;

internal sealed class Contact
{

    public event EventHandler<EventArgs> EmailChanged;
    public event EventHandler<EventArgs> PhoneChanged;
    public event EventHandler<EventArgs> PhoneCodeChanged;

    private readonly string? firstName;
    public string FirstName => firstName;

    private readonly Guid id;
    public Guid Id => id;

    private readonly string lastName;
    public string LastName => lastName;

    private string email = string.Empty;
    public string Email
    {
        get => email;
        set
        {
            if (!email.Equals(value))
            {
                email = value;
                OnEmailChanged(EventArgs.Empty);
            }
        }
    }
    private void OnEmailChanged(EventArgs e)
    {
       EmailChanged?.Invoke(this, e);
    }

    private string phone = string.Empty;
    public string Phone
    {
        get => phone;
        set
        {
            if (!phone.Equals(value))
            {
                phone = value;
                OnPhoneChanged(EventArgs.Empty);
            }
        }
    }

    private void OnPhoneChanged(EventArgs e)
    {
        PhoneChanged?.Invoke(this, e);
    }

    private string phoneCode = string.Empty;
    public string PhoneCode
    {
        get => phoneCode;
        set
        {
            if (!phoneCode.Equals(value))
            {
                phoneCode = value;
                OnPhoneCodeChanged(EventArgs.Empty);
            }
        }
    }

    private void OnPhoneCodeChanged(EventArgs e)
    {
        PhoneCodeChanged?.Invoke(this, e);
    }

    public Contact(string? firstName, string lastName)
        : this(firstName, lastName, Guid.NewGuid())
    { }

    public Contact(string? firstName, string lastName, Guid guid)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = guid;
    }
}
