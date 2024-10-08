using HelloWorldFour.Model;

namespace HelloWorldFour.View;

public static class Terminal
{
    public static void ShowSplash()
    {
        var title = "Service Discovery Tool";
        Console.WriteLine(new string('*', title.Length + 4));
        Console.WriteLine($"* {title} *");
        Console.WriteLine(new string('*', title.Length + 4));
    }
    public static (string?, string?, short) GetInputs()
    {
        Console.WriteLine("Alias ");
        string? alias = Console.ReadLine();
        Console.WriteLine("Ip");
        string? ip = Console.ReadLine();
        Console.WriteLine("Port");
        _ = short.TryParse(Console.ReadLine(), out short port);
        return (alias, ip, port);
    }

    public static void ShowInventory(Catalog serviceCatalog)
    {
        if (serviceCatalog.Services.Count == 0)
        {
            Console.WriteLine("Service Inventory is empty");
            return;
        }
        foreach (var service in serviceCatalog.Services)
        {
            Console.WriteLine(service);
        }
    }
}