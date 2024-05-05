using System;

namespace WF_WPF._MVVM_Example.ViewModels;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
internal sealed class DependsUponAttribute : Attribute
{
    private readonly string propertyName;

    public DependsUponAttribute(string propertyName)
    {
        this.propertyName = propertyName;
    }

    public string PropertyName => propertyName;
}
