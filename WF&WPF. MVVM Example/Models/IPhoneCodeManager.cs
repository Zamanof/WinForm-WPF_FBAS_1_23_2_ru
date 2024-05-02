
using System.Collections.Generic;

namespace WF_WPF._MVVM_Example.Models;

internal interface IPhoneCodeManager
{
    IEnumerable<string> PhoneCodes { get; }
    string GetAreaByPhoneCode(string phoneCode);
}
