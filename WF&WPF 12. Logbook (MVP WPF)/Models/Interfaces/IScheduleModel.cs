using WF_WPF_12._Logbook__MVP_WPF_.Models.Entities;

namespace WF_WPF_12._Logbook__MVP_WPF_.Models.Interfaces;

public interface IScheduleModel
{
    Lesson[] GetLessons(int teacherId);
}
