using WF_WPF_13._MVP_Example__multi_window_.Models.Entities;
namespace WF_WPF_13._MVP_Example__multi_window_.Views.ViewEventArgs;

public class ScheduleAddEventArgs: EventArgs
{
    public Schedule Schedule { get;}
    public ScheduleAddEventArgs(Schedule schedule)
    {
        Schedule = schedule;
    }
}
