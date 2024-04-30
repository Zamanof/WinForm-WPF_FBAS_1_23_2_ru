namespace LogbookLibrary;
public interface IScheduleModel
{
    Lesson[] GetLessons(int teacherId);
}
