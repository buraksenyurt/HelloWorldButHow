namespace HelloWorldFour.Model;

public class Catalog
{
    public IList<Service> Services { get; private set; } = [];
    public void Add(Service service)
    {
        Services.Add(service);
    }
}
