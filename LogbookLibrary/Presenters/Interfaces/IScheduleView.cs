using System;
using System.Collections;
namespace LogbookLibrary;

public interface IScheduleView
{
    void ShowSchedule(ICollection lessons);
    event EventHandler<int> ShowScheduleCalled;
}
