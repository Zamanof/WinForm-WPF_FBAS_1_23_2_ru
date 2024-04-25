using System.ComponentModel;

namespace WF_WPF_11._Templates;

class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public bool IsActive { get; set; }

    public Student(string? firstName, string? lastName, int age, bool isActive)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        IsActive = isActive;
    }
    public override string ToString()
    {
        var active = IsActive ? "Yes" : "No";
        return $"{FirstName} {LastName} - {DateTime.Now.Year - Age} Active:{active}";
    }
}
