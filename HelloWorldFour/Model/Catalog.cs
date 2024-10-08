namespace HelloWorldFour.Model;

public class Catalog
{
    public IList<Service> Services { get; private set; } = [];
    public void Add(Service service)
    {
        Console.WriteLine($"{service.Alias} added to catalog");
        Services.Add(service);
    }

    // public void WriteToFile()
    // {
    //     throw new NotImplementedException();
    // }
}
