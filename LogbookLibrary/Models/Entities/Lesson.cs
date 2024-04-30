namespace LogbookLibrary;

public class Lesson
{
    public string? Subject { get; set; }
    public string? Time { get; set; }
    public string? Group { get; set; }
    public override string ToString()
    {
        return $"{Time} {Group} { Subject}";
    }
}
