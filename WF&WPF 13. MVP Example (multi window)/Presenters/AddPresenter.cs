using System.Diagnostics;
using WF_WPF_13._MVP_Example__multi_window_.Models;
using WF_WPF_13._MVP_Example__multi_window_.Views.ViewEventArgs;
using WF_WPF_13._MVP_Example__multi_window_.Views.ViewInterfaces;

namespace WF_WPF_13._MVP_Example__multi_window_.Presenters;

public class AddPresenter
{
    private readonly IScheduleModel _model;
    private readonly IAddScheduleView _view;

    public AddPresenter(IScheduleModel model, IAddScheduleView view)
    {
        _model = model;
        _view = view;
        _view.AddScheduleCalled += _view_AddSchedulerCalled;
        _view.ViewClosing += _view_ViewClosing;
    }

    private void _view_ViewClosing(object? sender, EventArgs e)
    {
        Debug.WriteLine("VIEW IS CLOSING");
    }

    private void _view_AddSchedulerCalled(object? sender, ScheduleAddEventArgs e)
    {
        var schedule = e.Schedule;
        _model.AddSchedule(schedule);
    }

    public void Show()
    {
        _view.ShowDialog();
    }
}
