using HelloWorldFour.Model;

var title = "Service Discovery Tool";
Console.WriteLine(new string('*', title.Length+4));
Console.WriteLine($"* {title} *");
Console.WriteLine(new string('*', title.Length+4));
Console.WriteLine("To continue press Enter, for exit write exit :D or Ctrl+C");

var serviceCatalog = new Catalog();

while (true)
{
    if (Console.ReadLine().ToLower() == "exit")
        break;

    var (alias, ip, port) = GetInputs();

    // İlk sürüm
    // var endPoint = new Service(alias, ip, port);
    // Ulaşılmak istenen sürümlerden birisi (Factory)
    var endPoint = Service.Create(alias, ip, port);
    if (endPoint == null)
    {
        Console.WriteLine("Invalid endpoint");
        continue;
    }
    else
    {
        Console.WriteLine($"{endPoint} added to catalog");
        serviceCatalog.Add(endPoint);
    }
}

Console.WriteLine("Service Inventory");
foreach (var service in serviceCatalog.Services)
{
    Console.WriteLine(service);
}

static (string?, string?, short) GetInputs()
{
    Console.WriteLine("Alias ");
    string? alias = Console.ReadLine();
    Console.WriteLine("Ip");
    string? ip = Console.ReadLine();
    Console.WriteLine("Port");
    _ = short.TryParse(Console.ReadLine(), out short port);
    return (alias, ip, port);
}