using WF_WPF_13._MVP_Example__multi_window_.Models.Entities;
namespace WF_WPF_13._MVP_Example__multi_window_.Models;

public interface IScheduleModel
{
    Lesson[] GetTeacherLessons(int id);
    void AddSchedule(Schedule schedule);
}
