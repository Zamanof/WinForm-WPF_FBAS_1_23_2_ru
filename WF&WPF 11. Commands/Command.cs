using System.Windows.Input;

namespace WF_WPF_11._Commands;

internal abstract class Command : ICommand
{
    public event EventHandler? CanExecuteChanged;

    protected virtual bool CanExecute()
    {
        return true;
    }

    protected abstract void Execute();
    bool ICommand.CanExecute(object? parameter)
    {
        return CanExecute();
    }

    void ICommand.Execute(object? parameter)
    {
       Execute();
    }

    protected virtual void OnCanExecuteChanged(EventArgs e) { 
        CanExecuteChanged?.Invoke(this, e);
    }
    public void RaiseExecuteChanged()
    {
        OnCanExecuteChanged(EventArgs.Empty);
    }
}
