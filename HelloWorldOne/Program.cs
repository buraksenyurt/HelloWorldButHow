using HelloWorldOne;

var manager = new Supervisor();

var loaded = manager.Load(Path.Combine(Environment.CurrentDirectory, "Homeworks.json"));
Console.WriteLine("{0} homeworks loaded\n", loaded);

foreach (var hw in manager.GetHomeworks())
{
    Console.WriteLine("{0}\n", hw);
}

Console.WriteLine("Random Assignments for Students\n");

Console.WriteLine("{0}\n", manager.GetRandom());
Console.WriteLine("{0}\n", manager.GetRandom());