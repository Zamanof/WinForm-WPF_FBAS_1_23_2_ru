using WF_WPF_13._MVP_Example__multi_window_.Models.Entities;

namespace WF_WPF_13._MVP_Example__multi_window_.Models;

internal class FakeScheduleModel : IScheduleModel
{
    private Dictionary<int, Lesson[]> _schedule;

    public FakeScheduleModel()
    {
        _schedule = new Dictionary<int, Lesson[]> {
            {1,
                new[]
                {
                    new Lesson{Subject="C++", Time="09:00", Group="FBMS_1227"},
                    new Lesson{Subject="C++", Time="15:00", Group="FBMS_2322"},
                    new Lesson{Subject="C++", Time="19:00", Group="FBMS_3697"},
                }
            },
            {2,
                new[]
                {
                    new Lesson{Subject="C#", Time="09:00", Group="FBMS_Nov_23_9_ru"},
                    new Lesson{Subject="WPF", Time="15:00", Group="FBAS_1_23_2_ru"},
                    new Lesson{Subject="JavaScript", Time="18:00", Group="FBES_1227_az"},
                }
            }
        };
    }

    public void AddSchedule(Schedule schedule)
    {
        _schedule.Add(schedule.Id, schedule.Lessons);
    }

    public Lesson[] GetTeacherLessons(int id)
    {
        if (_schedule.TryGetValue(id, out var lessons))
        {
            return lessons;
        }
        return Array.Empty<Lesson>();
    }
}
