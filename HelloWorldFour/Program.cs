using HelloWorldFour.Model;
using HelloWorldFour.View;

var serviceCatalog = new Catalog();

/*
    Bir nesneye event yükleme biraz kafa karıştırıcı olabilir.
    Şimdilik sadece Ctrl+C/Break durumlarını ele alıp programı kapatmak istediğimizde
    ekrana Inventory'nin son halini basmak için kullanıldığı ifade edilebilir.
*/
Console.CancelKeyPress += (obj, args) => Terminal.ShowInventory(serviceCatalog);

// Basit görüntüleme işlemleri bile olsa bunları metotlaştırma
Terminal.ShowSplash();

// Sonsuz döngü
while (true)
{
    Console.WriteLine("To continue press Enter, for exit press Ctrl+C/Break");

    // Tuple Kullanımı
    var (alias, ip, port) = Terminal.GetInputs();

    // İlk sürüm
    // var endPoint = new Service(alias, ip, port);

    // Ulaşılmak istenen sürümlerden birisi (Static Factory Method kullanımı)
    var endPoint = Service.Create(alias, ip, port);
    if (endPoint != null)
    {
        serviceCatalog.Add(endPoint);
    }
}