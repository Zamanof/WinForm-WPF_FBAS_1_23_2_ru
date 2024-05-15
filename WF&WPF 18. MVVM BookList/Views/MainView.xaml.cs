using System.Windows;
using System.Windows.Controls;
using WF_WPF_18._MVVM_BookList.Models;
using WF_WPF_18._MVVM_BookList.ViewModels;

namespace WF_WPF_18._MVVM_BookList.Views;

/// <summary>
/// Interaction logic for MainView.xaml
/// </summary>
internal sealed partial class MainView : Window
{
    private readonly Library _model;
    public MainView(Library model)
    {
        this._model = model;
        InitializeComponent();
    }

    private void AddBook_Click(object sender, RoutedEventArgs e)
    {
        var book = new Book(name.Text, author.Text, publishDate?.SelectedDate!.Value);
        _model.Add(book);
        name.Clear();
        author.Clear();
        publishDate!.SelectedDate = null;
    }

    private void BookList_Click(object sender, RoutedEventArgs e)
    {
        var view = new ListBookView { DataContext = new ViewModel(_model) };
        view.Show();
    }
    private void SingleBook_Click(object sender, RoutedEventArgs e)
    {
        var view = new SingleBookView { DataContext = new ViewModel(_model) };
        view.Show();
    }

    private void Author_TextChanged(object sender, TextChangedEventArgs e)
    {
        UpdateAddButtonState();
    }
    private void Name_TextChanged(object sender, TextChangedEventArgs e)
    {
        UpdateAddButtonState();
    }

    private void PublishDate_SelectedDataChanged(object sender, SelectionChangedEventArgs e)
    {
        UpdateAddButtonState();
    }

    private void UpdateAddButtonState()
    {
       add.IsEnabled = name.Text.Length > 0 && author.Text.Length > 0 && publishDate.SelectedDate.HasValue;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        UpdateAddButtonState();
    }
}
