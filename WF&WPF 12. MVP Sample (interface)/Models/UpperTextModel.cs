using WF_WPF_12._MVP_Sample__interface_.Models.Interfaces;

namespace WF_WPF_12._MVP_Sample__interface_.Models;

internal class UpperTextModel : IModel
{
    public string TextHandler(string text)
    {
        return text.ToUpper();
    }
}
