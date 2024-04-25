using System.Collections.ObjectModel;

namespace WF_WPF_11._Templates;
class DataSource
{
    private ObservableCollection<Student> students;
    public ObservableCollection<Student> Students
    {
        get => students;
    }

    public DataSource()
    {
        students = new ObservableCollection<Student> { 
        new Student(firstName:"Salam", lastName:"Salamzade", age:30, isActive:true),
        new Student(firstName:"Laman", lastName:"Aslanova", age:27, isActive:true),
        new Student(firstName:"Camal", lastName:"Babayev", age:15, isActive:false),
        new Student(firstName:"Faiq", lastName:"Ibrahimov", age:15, isActive:false),
        new Student(firstName:"Alina", lastName:"Orucova", age:15, isActive:true),
        new Student(firstName:"Rasul", lastName:"Umud", age:16, isActive:false)
        };
    }
}
