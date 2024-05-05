using System;
namespace WF_WPF._MVVM_Example.ViewModels;

[AttributeUsage(AttributeTargets.Property)]
internal sealed class CanExecuteAttribute : Attribute
{
    private readonly string propertyName;

    public CanExecuteAttribute(string propertyName)
    {
        this.propertyName = propertyName;
    }

    public string PropertyName => propertyName;
}
