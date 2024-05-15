using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using WF_WPF_18._MVVM_BookList.Commands;
using WF_WPF_18._MVVM_BookList.Models;
using WF_WPF_18._MVVM_BookList.Views;

namespace WF_WPF_18._MVVM_BookList.ViewModels;

internal sealed class ViewModel: INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private int _currendBookIndex = -1;

    private Book _currentBook;
    public Book CurrentBook
    {
        get => _currentBook;
        set
        {
            if(!_currentBook?.Equals(value)?? value != null)
            {
                _currentBook = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentBook)));
            }
        }
    }

    private void OnPropertyChanged(PropertyChangedEventArgs propertyChangedEventArgs)
    {
        PropertyChanged?.Invoke(this, propertyChangedEventArgs);
    }

    private readonly Library _library;

    private readonly Command? _nextCommand;
    public ICommand NextCommand => _nextCommand!;

    private readonly Command? _previousCommand;
    public ICommand PreviousCommand => _previousCommand!;

    public ViewModel(Library library)
    {
        _library = library;
        _nextCommand = new DelegateCommand(LoadNext, CanLoadNext);
        _previousCommand = new DelegateCommand(LoadPrevious, CanLoadPrevious);
        if(_library.Books.Count > 0)
        {
            Load(bookIndex: 0);
        }
        _library.Books.CollectionChanged += (sender, e) => UpdatePreviousNextState();
        PropertyChanged += (sender, e) =>
        {
            if (e.PropertyName.Equals(nameof(CurrentBook)))
            {
                UpdatePreviousNextState();
            }
        };
    }

    public IEnumerable<Book> Books => _library.Books;

    private void UpdatePreviousNextState()
    {
        _nextCommand?.RaiseCanExecuteChanged();
        _previousCommand?.RaiseCanExecuteChanged();
    }

    private void Load(int bookIndex)
    {
       _currendBookIndex = bookIndex;
        CurrentBook = _library.Books[_currendBookIndex];
    }

    private bool CanLoadPrevious()
    {
        return _currendBookIndex > 0;
    }

    private void LoadPrevious()
    {
       Load(_currendBookIndex -1);
    }

    private bool CanLoadNext()
    {
        return _currendBookIndex < _library.Books.Count - 1;
    }

    private void LoadNext()
    {
       Load(_currendBookIndex +1);
    }
}
