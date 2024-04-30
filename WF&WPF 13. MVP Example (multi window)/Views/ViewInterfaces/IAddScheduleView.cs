using WF_WPF_13._MVP_Example__multi_window_.Views.ViewEventArgs;

namespace WF_WPF_13._MVP_Example__multi_window_.Views.ViewInterfaces;

public interface IAddScheduleView
{
    event EventHandler<ScheduleAddEventArgs> AddScheduleCalled;
    event EventHandler ViewClosing;
    void ShowDialog();
}
