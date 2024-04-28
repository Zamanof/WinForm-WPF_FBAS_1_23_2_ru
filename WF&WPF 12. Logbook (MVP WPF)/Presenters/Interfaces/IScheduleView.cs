using System;
using System.Collections;
using WF_WPF_12._Logbook__MVP_WPF_.Models.Entities;

namespace WF_WPF_12._Logbook__MVP_WPF_.Presenters.Interfaces;

public interface IScheduleView
{
    void ShowSchedule(ICollection lessons);
    event EventHandler<int> ShowScheduleCalled;
}
