namespace HelloWorldOne;

public class Homework
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Summary { get; set; }
    public int Level { get; set; }
    public override string ToString()
    {
        return $"{Id}\n{Title}({Level})\n{Summary}";
    }
}
