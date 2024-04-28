using System;
using System.Collections.Generic;
using WF_WPF_12._Logbook__MVP_WPF_.Models.Interfaces;

namespace WF_WPF_12._Logbook__MVP_WPF_.Models.Entities;

public class FakeScheduleModel: IScheduleModel
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
    public Lesson[] GetLessons(int teacherId)
    {
        if(_schedule.TryGetValue(teacherId, out var lessons)){
            return lessons;
        }
        return Array.Empty<Lesson>();
    }
}
