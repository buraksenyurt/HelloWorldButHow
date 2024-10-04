using Model;

var identityManager = new IdentityManager("Users.txt");
foreach (var user in identityManager.Users)
{
    Console.WriteLine("{0}", user); // Record türünün doğrudan JSON çıktısı veriyor olması (Kalp)
}

namespace Model
{
    public class IdentityManager
    {
        private readonly IList<User> users = [];
        public IdentityManager(string fileName)
        {
            var file = Path.Combine(Environment.CurrentDirectory, fileName);
            var lines = File.ReadAllLines(file);
            for (int i = 0; i < lines.Length; i++)
            {
                var columns = lines[i].Split(',');
                // Kolon adlarından 0,1,2 ne anlama geliyor?
                users.Add(new User(i, columns[0], columns[1], columns[2]));
            }
        }
        public IList<User> Users
        {
            get
            {
                return users;
            }
        }
    }
    public record User(int Id, string FullName, string UserName, string Email);
}
