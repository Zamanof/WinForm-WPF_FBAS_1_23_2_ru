using System;

namespace WF_WPF_12._Logbook__MVP_WPF_;

internal class ShowScheduleEventArgs:EventArgs
{
    public int TeacherId { get; }
    public ShowScheduleEventArgs(int teacherId)
    {
        TeacherId = teacherId;
    }

}
