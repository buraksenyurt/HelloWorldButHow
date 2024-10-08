namespace HelloWorldFour.Model;

/*
    Version 1

    Bu ilk versiyonda bazı doğrulama ihtiyaçları ortaya çıkmaktadır.
    Servis nesnesinin boş veya geçersiz uzunlukta bir Alias ile oluşturulmasını istemeyiz.
    Ip bilgisinin geçerli bir değer olması beklenir, keza port bilgisi de öyle.

    Bu nedenle nesne oluşturma işi için Creational desenlerden birisi ele alınabilir.
    Ancak bir hello world uygulaması için bu tip pattern'ler biraz kafa karıştırıcı olabilir.
    Hafifsiklet bir çözüm daha iyi olabilir. Örneğin nesne oluşturma işini static bir factory metoduna devredebiliriz.
    Ya da basit bir builder düzeneği de kurabiliriz.

    İlk önce aşağıdaki Service nesne örneği ile ilerlenir. Sonrasında statik factory metoda geçilebilir.
    Builder kullanımı farklı bir senaryo için ödev olarak da verilebilir. 
    
    Söz gelimi bir oyun motoru nesnesi inşa edilirken pencere ayarlarının verilmesi, resource'ların yüklenmesi,
    sistem fonksiyonlarının yerleştirilmesi builder tarafından ele alınabilir.
 */
//public class Service(string Alias, string Ip, short Port)
//{
//    public string Alias { get; private set; } = Alias;
//    public string Ip { get; private set; } = Ip;
//    public short Port { get; private set; } = Port;

//    public override string ToString()
//    {
//        return $"{Alias} https://{Ip:Port}";
//    }
//}

/* 
    Static Factory Method Versiyonu

    Bu sürümde geçersiz girişler console ekranına bilgi olarak basılmaktadır. Bu tartışmaya açılabilir.
    Gerçek hayat örneklerinde loglama yapılması veya dönüş tipinde Null yerine bir Response türü kullanılarak statü bildirimi verilmesi daha ideal olabilir. 
    Gerçekten bir kesme yapmak gerekiyorsa Exception fırlatılabilir.
 */
public class Service
{
    public string Alias { get; private set; }
    public string Ip { get; private set; }
    public short Port { get; private set; }
    private Service(string alias, string ip, short port)
    {
        Alias = alias;
        Ip = ip;
        Port = port;
    }
    public override string ToString()
    {
        return $"{Alias} https://{Ip}:{Port}";
    }

    public static Service? Create(string alias, string ip, short port)
    {
        if (string.IsNullOrWhiteSpace(alias) || alias.Length < 5 || alias.Length > 15)
        {
            Console.WriteLine("Alias must be between 5 and 15 characters.");
            return null;
        }

        if (!System.Net.IPAddress.TryParse(ip, out _))
        {
            Console.WriteLine("Invalid IP address.");
            return null;
        }

        if (port <= 0)
        {
            Console.WriteLine("Invalid port.");
            return null;
        }

        return new Service(alias, ip, port);
    }
}