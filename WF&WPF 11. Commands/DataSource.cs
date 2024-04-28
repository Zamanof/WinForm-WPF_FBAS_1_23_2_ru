using System.ComponentModel;
using System.Windows.Input;

namespace WF_WPF_11._Commands;

internal sealed class DataSource : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private readonly Command blueCommand;
    private readonly Command redCommand;
    private readonly Command greenCommand;

    public DataSource()
    {
        blueCommand = new DelegateCommand(
            ()=> SelectedColor = "Blue",
            () => SelectedColor != "Blue"
            );
        redCommand = new DelegateCommand(
            () => SelectedColor = "Red",
            () => SelectedColor != "Red"
            );
        greenCommand = new DelegateCommand(
            () => SelectedColor = "Green",
            () => SelectedColor != "Green"
            );
        PropertyChanged += (s, e) =>
        {
            if (e.PropertyName.Equals(nameof(SelectedColor)))
            {
                blueCommand.RaiseExecuteChanged();
                greenCommand.RaiseExecuteChanged();
                redCommand.RaiseExecuteChanged();
            }
        };
    }

    public ICommand BlueCommand => blueCommand;
    public ICommand RedCommand => redCommand;
    public ICommand GreenCommand => greenCommand;

    private string _selectedColor = "Black";
    public string SelectedColor
    {
        get => _selectedColor;
        set
        {
            if (!_selectedColor.Equals(value))
            {
                _selectedColor = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedColor)));
            }
        }
    }

    private void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        PropertyChanged?.Invoke(this, e);
    }
}
