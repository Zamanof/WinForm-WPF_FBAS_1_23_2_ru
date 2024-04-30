using WF_WPF_13._MVP_Example__multi_window_.Models.Entities;
using WF_WPF_13._MVP_Example__multi_window_.Views.ViewEventArgs;

namespace WF_WPF_13._MVP_Example__multi_window_.Views.ViewInterfaces;

public interface IScheduleView
{
    event EventHandler<ScheduleShowEventArgs> ShowScheduleCalled;
    event EventHandler<EventArgs> AddScheduleCalled;
    void ShowSchedule(Lesson[] lessons);
    void ClearTeacherIdEntry();
}
