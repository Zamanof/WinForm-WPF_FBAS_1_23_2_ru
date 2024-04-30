namespace WF_WPF_13._MVP_Example__multi_window_.Views.ViewEventArgs;

public class ScheduleShowEventArgs: EventArgs
{
    public int TeacherId { get;}
    public ScheduleShowEventArgs(int teacherId)
    {
        TeacherId = teacherId;
    }
}
