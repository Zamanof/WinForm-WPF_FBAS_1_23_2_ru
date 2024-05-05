using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using WF_WPF._MVVM_Example.ViewModels;

namespace WF_WPF._MVVM_Example.ViewModels;

internal abstract class ViewModel<TViewModel> : INotifyPropertyChanged
    where TViewModel : ViewModel<TViewModel>
{
    private static readonly Lazy<IReadOnlyDictionary<string, IEnumerable<Func<TViewModel, Command>>>> propertyToDependentCommandsMappings;
    private static readonly Lazy<IReadOnlyDictionary<string, IEnumerable<Action<TViewModel>>>> propertyToDependentMethodsMappings;
    private static readonly Lazy<IReadOnlyDictionary<string, IEnumerable<string>>> propertyToDependentPropertiesMappings;

    static ViewModel()
    {
        propertyToDependentCommandsMappings = new Lazy<IReadOnlyDictionary<string, IEnumerable<Func<TViewModel, Command>>>>(CreatePropertyToDependentCommandsMappings);
        propertyToDependentMethodsMappings = new Lazy<IReadOnlyDictionary<string, IEnumerable<Action<TViewModel>>>>(CreatePropertyToDependentMethodsMappings);
        propertyToDependentPropertiesMappings = new Lazy<IReadOnlyDictionary<string, IEnumerable<string>>>(CreatePropertyToDependentPropertiesMappings);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private static IReadOnlyDictionary<string, IEnumerable<Func<TViewModel, Command>>> CreatePropertyToDependentCommandsMappings()
    {
        var propertyToDependentCommandsMappings = new Dictionary<string, ICollection<Func<TViewModel, Command>>>();

        Type viewModelType = typeof(TViewModel);

        PropertyInfo[] properties = viewModelType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        foreach (PropertyInfo property in properties)
        {
            CanExecuteAttribute attribute = property.GetCustomAttribute<CanExecuteAttribute>();
            if (!(attribute is null))
            {
                if (!propertyToDependentCommandsMappings.TryGetValue(attribute.PropertyName, out ICollection<Func<TViewModel, Command>> dependentCommands))
                {
                    dependentCommands = new List<Func<TViewModel, Command>>();

                    propertyToDependentCommandsMappings.Add(attribute.PropertyName, dependentCommands);
                }

                var propertyGetterDelegate = (Func<TViewModel, object>)property.GetMethod.CreateDelegate(typeof(Func<TViewModel, object>));
                Func<TViewModel, Command> propertyGetterWrapper = instance => (Command)propertyGetterDelegate(instance);

                dependentCommands.Add(propertyGetterWrapper);
            }
        }

        return propertyToDependentCommandsMappings.ToDictionary(
            propertyToDependentCommandsMapping => propertyToDependentCommandsMapping.Key,
            propertyToDependentCommandsMapping => (IEnumerable<Func<TViewModel, Command>>)propertyToDependentCommandsMapping.Value
        );
    }

    private static IReadOnlyDictionary<string, IEnumerable<Action<TViewModel>>> CreatePropertyToDependentMethodsMappings()
    {
        var propertyToDependentMethodsMappings = new Dictionary<string, ICollection<Action<TViewModel>>>();

        Type viewModelType = typeof(TViewModel);

        MethodInfo[] methods = viewModelType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        foreach (MethodInfo method in methods)
        {
            IEnumerable<DependsUponAttribute> attributes = method.GetCustomAttributes<DependsUponAttribute>();
            foreach (DependsUponAttribute attribute in attributes)
            {
                if (!propertyToDependentMethodsMappings.TryGetValue(attribute.PropertyName, out ICollection<Action<TViewModel>> dependentMethods))
                {
                    dependentMethods = new List<Action<TViewModel>>();

                    propertyToDependentMethodsMappings.Add(attribute.PropertyName, dependentMethods);
                }

                var methodDelegate = (Action<TViewModel>)method.CreateDelegate(typeof(Action<TViewModel>));

                dependentMethods.Add(methodDelegate);
            }
        }

        return propertyToDependentMethodsMappings.ToDictionary(
            propertyToDependentMethodsMapping => propertyToDependentMethodsMapping.Key,
            propertyToDependentMethodsMapping => (IEnumerable<Action<TViewModel>>)propertyToDependentMethodsMapping.Value
        );
    }

    private static IReadOnlyDictionary<string, IEnumerable<string>> CreatePropertyToDependentPropertiesMappings()
    {
        var propertyToDependentPropertiesMappings = new Dictionary<string, ICollection<string>>();

        Type viewModelType = typeof(TViewModel);

        PropertyInfo[] properties = viewModelType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        foreach (PropertyInfo property in properties)
        {
            IEnumerable<DependsUponAttribute> attributes = property.GetCustomAttributes<DependsUponAttribute>();
            foreach (DependsUponAttribute attribute in attributes)
            {
                if (!propertyToDependentPropertiesMappings.TryGetValue(attribute.PropertyName, out ICollection<string> dependentProperties))
                {
                    dependentProperties = new List<string>();

                    propertyToDependentPropertiesMappings.Add(attribute.PropertyName, dependentProperties);
                }

                dependentProperties.Add(property.Name);
            }
        }

        return propertyToDependentPropertiesMappings.ToDictionary(
            propertyToDependentPropertiesMapping => propertyToDependentPropertiesMapping.Key,
            propertyToDependentPropertiesMapping => (IEnumerable<string>)propertyToDependentPropertiesMapping.Value
        );
    }

    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        PropertyChanged?.Invoke(this, e);

        RaiseDependentProperties(e.PropertyName);
        RaiseDependentMethods(e.PropertyName);
        RaiseDependentCommands(e.PropertyName);
    }

    private void RaiseDependentCommands(string propertyName)
    {
        if (propertyToDependentCommandsMappings.Value.TryGetValue(propertyName, out IEnumerable<Func<TViewModel, Command>> dependentCommands))
        {
            foreach (Func<TViewModel, Command> dependentCommand in dependentCommands)
            {
                Command command = dependentCommand((TViewModel)this);
                command.RaiseCanExecuteChanged();

            }
        }
    }

    private void RaiseDependentMethods(string propertyName)
    {
        if (propertyToDependentMethodsMappings.Value.TryGetValue(propertyName, out IEnumerable<Action<TViewModel>> dependentMethods))
        {
            foreach (Action<TViewModel> dependentMethod in dependentMethods)
            {
                dependentMethod((TViewModel)this);
            }
        }
    }

    private void RaiseDependentProperties(string propertyName)
    {
        if (propertyToDependentPropertiesMappings.Value.TryGetValue(propertyName, out IEnumerable<string> dependentProperties))
        {
            foreach (string dependentProperty in dependentProperties)
            {
                OnPropertyChanged(new PropertyChangedEventArgs(dependentProperty));
            }
        }
    }

    protected void SetProperty<T>(ref T oldValue, T newValue, [CallerMemberName] string propertyName = null)
    {
        if (!oldValue?.Equals(newValue) ?? newValue != null)
        {
            oldValue = newValue;

            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    }
}
