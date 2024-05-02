namespace WF_WPF._MVVM_Example.Models;

internal class PhoneCodesFile
{
    public const string Path = @"..\..\PhoneCodes.xml";
    public static class Root
    {
        public const string ElementName = "Areas";
        public static class Area
        {
            public const string ElementName = "Area";
            public static class Attributes
            {
                public const string Name = "Name";
            }
            public static class PhoneCode
            {
                public const string ElementName = "PhoneCode";
                public static class Attributes
                {
                    public const string Value = "Value";
                }
            }
        }
    }
}
