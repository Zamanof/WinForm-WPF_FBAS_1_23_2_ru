using WF_WPF_13._MVP_Example__multi_window_.Models;
using WF_WPF_13._MVP_Example__multi_window_.Views.ViewEventArgs;
using WF_WPF_13._MVP_Example__multi_window_.Views.ViewInterfaces;

namespace WF_WPF_13._MVP_Example__multi_window_.Presenters;

public class SchedulePresenter
{
    private IScheduleModel _model;
    private IScheduleView _view;

    public SchedulePresenter(IScheduleModel model, IScheduleView view)
    {
        _model = model;
        _view = view;
        _view.ShowScheduleCalled += view_ShowScheduleCalled;
        _view.AddScheduleCalled += view_AddScheduleCalled;
    }

    private void view_AddScheduleCalled(object? sender, EventArgs e)
    {
        var presenter = new AddPresenter(_model, new AddForm());
        presenter.Show();
    }

    private void view_ShowScheduleCalled(object? sender, ScheduleShowEventArgs e)
    {
        var lessons = _model.GetTeacherLessons(e.TeacherId);
        _view.ShowSchedule(lessons);
        _view.ClearTeacherIdEntry();
    }
}
