using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WF_WPF._MVVM_Example.Models;

internal class PhoneCodeManager : IPhoneCodeManager
{
    public IEnumerable<string> PhoneCodes => GetPhoneCodes();

    private IEnumerable<string> GetPhoneCodes()
    {
        var phoneCodes = new List<string>();
        XDocument document = XDocument.Load(PhoneCodesFile.Path);
        IEnumerable<XElement> areaElements = document
            .Element(PhoneCodesFile.Root.ElementName)!.
            Elements(PhoneCodesFile.Root.Area.ElementName);
        foreach (XElement areaElement in areaElements)
        {
            IEnumerable<XElement> codeElements = areaElement.Elements(PhoneCodesFile.Root.Area.PhoneCode.ElementName);
            foreach(XElement codeElement in codeElements)
            {
                XAttribute valueAttribute = codeElement.Attribute(PhoneCodesFile.Root.Area.PhoneCode.Attributes.Value)!;
                phoneCodes.Add(valueAttribute.Value);
            }
        }
        phoneCodes.Sort();
        return phoneCodes;
    }

    public string GetAreaByPhoneCode(string phoneCode)
    {
        XDocument document = XDocument.Load(PhoneCodesFile.Path);
        IEnumerable<XElement> areaElements = document
            .Element(PhoneCodesFile.Root.ElementName)!.
            Elements(PhoneCodesFile.Root.Area.ElementName);

        foreach (XElement areaElement in areaElements)
        {
            IEnumerable<XElement> codeElements = areaElement.Elements(PhoneCodesFile.Root.Area.PhoneCode.ElementName);
            foreach (XElement codeElement in codeElements)
            {
                XAttribute valueAttribute = codeElement.Attribute(PhoneCodesFile.Root.Area.PhoneCode.Attributes.Value)!;
                if (valueAttribute.Value.Equals(phoneCode))
                {
                    return areaElement.Attribute(PhoneCodesFile.Root.Area.Attributes.Name)!.Value;

                }
            }
        }
        throw new Exception();
    }
}
