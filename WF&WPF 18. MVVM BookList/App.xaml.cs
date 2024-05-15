using System;
using System.Windows;
using WF_WPF_18._MVVM_BookList.Models;
using WF_WPF_18._MVVM_BookList.Views;

namespace WF_WPF_18._MVVM_BookList;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
internal sealed partial class App : Application
{
    public App()
    {
        ShutdownMode = ShutdownMode.OnMainWindowClose;
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var book1 = new Book("Человек Амфибия", "Александр Беляев", new DateTime(1928, 5, 15));
        var book2 = new Book("И никаго не стало", "Агата Кристи", new DateTime(1943, 11, 6));
        var book3 = new Book("Голова Профессора Доуэля", "Александр Беляев", new DateTime(1925, 10, 7));
        var book4 = new Book("Убийство Роджера Экройда", "Агата Кристи", new DateTime(1926, 12, 1));
        var book5 = new Book("Собака Баскервилей", "Сэр Артур Конан Дойл", new DateTime(1902, 1, 1));
        var library = new Library();
        library.Add(book1);
        library.Add(book2);
        library.Add(book3);
        library.Add(book4);
        library.Add(book5);
        var view = new MainView(library);
        view.Show();
    }
}
