using WF_WPF_12._Logbook__MVP_WPF_.Models.Interfaces;
using WF_WPF_12._Logbook__MVP_WPF_.Presenters.Interfaces;

namespace WF_WPF_12._Logbook__MVP_WPF_.Presenters;

internal class SchedulePresnter
{
    const int TeacherId = 1;
    private IScheduleModel _model;
    private IScheduleView _view;

    public SchedulePresnter(IScheduleModel model, IScheduleView view)
    {
        _model = model;
        _view = view;
        _view.ShowScheduleCalled += View_ShowScheduleCalled;
    }

    private void View_ShowScheduleCalled(object? sender, int teacherId)
    {
        var lessons = _model.GetLessons(teacherId);
        _view.ShowSchedule(lessons);
    }


}
