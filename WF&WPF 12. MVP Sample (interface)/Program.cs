using WF_WPF_12._MVP_Sample__interface_.Models;
using WF_WPF_12._MVP_Sample__interface_.Presenters;

namespace WF_WPF_12._MVP_Sample__interface_;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var _model = new TextAddModel();
        //var _model = new UpperTextModel();
        var _view = new Form1();
        var presenter = new Presenter(_model, _view);
        Application.Run(_view);
    }
}