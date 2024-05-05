using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_WPF._MVVM_Example.Models
{
    internal static class ContactsFile
    {
        public const string Path = @"..\..\..\Contacts.xml";
        public static class Root
        {
            public const string ElementName = "Contacts";
            public static class Contact
            {
                public const string ElementName = "Contact";
                public static class Attributes
                {
                    public const string Email = "Email";
                    public const string FirstName = "FirstName";
                    public const string Id = "Id";
                    public const string LastName = "LastName";
                    public const string Phone = "Phone";
                    public const string PhoneCode = "PhoneCode";
                }
            }
        }
    }
}
