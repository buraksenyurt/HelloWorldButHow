using System.Text.Json;
using System.Text.Json.Serialization;

namespace HelloWorldOne;

public class Supervisor
{
    private List<Homework> _homeworks = [];

    public Guid Add(Homework homework)
    {
        _homeworks.Add(homework);
        return homework.Id;
    }

    public Homework? GetHomework(Guid id)
    {
        return _homeworks.Where(h => h.Id == id).FirstOrDefault();
    }

    public Homework? GetRandom()
    {
        Random rnd = new Random();
        var index = rnd.Next(0, _homeworks.Count);
        return _homeworks[index];
    }

    public int Load(string path)
    {
        var content = File.ReadAllText(path);

        _homeworks = JsonSerializer.Deserialize<List<Homework>>(content, options: BuildSerializerSettings()) ?? [];
        return _homeworks.Count;
    }

    public List<Homework> GetHomeworks()
    {
        return _homeworks;
    }

    private static JsonSerializerOptions BuildSerializerSettings()
    {
        var settings = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        return settings;
    }
}
