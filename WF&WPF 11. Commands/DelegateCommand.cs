namespace WF_WPF_11._Commands;

internal class DelegateCommand : Command
{
    private static readonly Func<bool> defaultCanExecuteMethod = () => true;
    private readonly Func<bool> canExecuteMethod;
    private readonly Action executeMethod;

    public DelegateCommand(Action executeMethod, Func<bool> canExecuteMethod)
    {
        this.executeMethod = executeMethod;
        this.canExecuteMethod = canExecuteMethod;
    }

    public DelegateCommand(Action executeMethod): this(executeMethod, defaultCanExecuteMethod)
    {}

    protected override bool CanExecute()
    {
        return canExecuteMethod();
    }
    protected override void Execute()
    {
       executeMethod();
    }
}
