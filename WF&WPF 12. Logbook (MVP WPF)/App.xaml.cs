using LogbookLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;


namespace WF_WPF_12._Logbook__MVP_WPF_;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        // View
        var view = new MainWindow();
        // Model
        IScheduleModel model = new FakeScheduleModel();
        var presenter = new SchedulePresnter(model, view);
        MainWindow = view;
        MainWindow.ShowDialog();
    }
}
