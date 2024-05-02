using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WF_WPF._MVVM_Example.Models;

internal class ContactManger : IContactManager
{
    public IEnumerable<Contact> Contacts => GetContacts();

    private IEnumerable<Contact> GetContacts()
    {
        var contacts = new List<Contact>();
        XDocument document = XDocument.Load(ContactsFile.Path);
        IEnumerable<XElement> contactElements = document
            .Element(ContactsFile.Root.ElementName)!
            .Elements(ContactsFile.Root.Contact.ElementName);
        foreach (XElement contactElement in contactElements)
        {
            XAttribute idAttribute = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.Id)!;
            XAttribute firstNameAttribute = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.FirstName)!;
            XAttribute lastNameAttribute = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.LastName)!;
            XAttribute emailAttribute = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.Email)!;
            XAttribute phoneAttribute = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.Phone)!;
            XAttribute phoneCodeAttribute = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.PhoneCode)!;
            var contact = new Contact(firstNameAttribute.Value, lastNameAttribute.Value, new Guid(idAttribute.Value))
            {
                Email = emailAttribute.Value,
                Phone = phoneAttribute.Value,
                PhoneCode = phoneCodeAttribute.Value
            };
            contacts.Add(contact);
        }
        return contacts;

    }

    public event EventHandler<ContactEventArgs> ContactAdded;
    public event EventHandler<ContactEventArgs> ContactDeleted;

    public void AddContact(Contact contact)
    {
        XDocument document = XDocument.Load(ContactsFile.Path);
        document.Root.Add(
            new XElement(ContactsFile.Root.Contact.ElementName,
            new XAttribute(ContactsFile.Root.Contact.Attributes.Email, contact.Email),
            new XAttribute(ContactsFile.Root.Contact.Attributes.FirstName, contact.FirstName),
            new XAttribute(ContactsFile.Root.Contact.Attributes.LastName, contact.LastName),
            new XAttribute(ContactsFile.Root.Contact.Attributes.Phone, contact.Phone),
            new XAttribute(ContactsFile.Root.Contact.Attributes.PhoneCode, contact.PhoneCode),
            new XAttribute(ContactsFile.Root.Contact.Attributes.Id, contact.Id)
            )
            );
        document.Save(ContactsFile.Path);
        OnContactAdded(new ContactEventArgs(contact));

    }

    private void OnContactAdded(ContactEventArgs contactEventArgs)
    {
        ContactAdded.Invoke(this, contactEventArgs);
    }

    public void DeleteContact(Contact contact)
    {
        XDocument document = XDocument.Load(ContactsFile.Path);
        IEnumerable<XElement> contactElements = document
            .Element(ContactsFile.Root.ElementName)!
            .Elements(ContactsFile.Root.Contact.ElementName);
        foreach (XElement contactElement in contactElements)
        {
            XAttribute idAttributre = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.Id)!;
            var id = new Guid(idAttributre.Value);
            if (id.Equals(contact.Id))
            {
                contactElement.Remove();
                document.Save(ContactsFile.Path);
                break;
            }
        }
        OnContactDeleted(new ContactEventArgs(contact));

    }

    private void OnContactDeleted(ContactEventArgs contactEventArgs)
    {
       ContactDeleted.Invoke(this, contactEventArgs);
    }

    public void UpdateContact(Contact contact)
    {
        XDocument document = XDocument.Load(ContactsFile.Path);
        IEnumerable<XElement> contactElements = document
            .Element(ContactsFile.Root.ElementName)!
            .Elements(ContactsFile.Root.Contact.ElementName);
        foreach (XElement contactElement in contactElements)
        {
            XAttribute idAttributre = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.Id)!;
            var id = new Guid(idAttributre.Value);
            if (id.Equals(contact.Id))
            {
                XAttribute phoneAttribute = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.Phone)!;
                phoneAttribute.Value = contact.Phone;

                XAttribute phoneCodeAttribute = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.PhoneCode)!;
                phoneCodeAttribute.Value = contact.PhoneCode;

                XAttribute emailAttribute = contactElement.Attribute(ContactsFile.Root.Contact.Attributes.Email)!;
                emailAttribute.Value = contact.Email;
                document.Save(ContactsFile.Path);
                break;
            }
        }
    }
}
