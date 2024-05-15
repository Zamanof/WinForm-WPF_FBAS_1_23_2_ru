using System;

namespace WF_WPF_18._MVVM_BookList.Commands;

internal sealed class DelegateCommand : Command
{
    private static readonly Func<bool> defaultCanExecuteMethod = () => true;

    private readonly Func<bool> canExecuteMethod;

    private readonly Action executeMethod;
 

    public DelegateCommand(Action executeMethod)
        :this(executeMethod, defaultCanExecuteMethod)
    {
    }

    public DelegateCommand(Action executeMethod, Func<bool> canExecuteMethod)
    {
        this.executeMethod = executeMethod;
        this.canExecuteMethod = canExecuteMethod;
        
    }

    protected override void Execute()
    {
        executeMethod();
    }

    protected override bool CanExecute()
    {
        return canExecuteMethod();
    }
    
   
}
