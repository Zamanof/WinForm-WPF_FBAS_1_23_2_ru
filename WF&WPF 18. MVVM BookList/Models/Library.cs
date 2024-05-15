using System.Collections.ObjectModel;
using WF_WPF_18._MVVM_BookList.Views;

namespace WF_WPF_18._MVVM_BookList.Models;

internal sealed class Library
{
    private readonly ObservableCollection<Book> _books = new ObservableCollection<Book>();
    public ObservableCollection<Book> Books => _books;

    public void Add(Book book)
    {
        _books.Add(book);
    }
}
