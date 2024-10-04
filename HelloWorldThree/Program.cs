using Model;

var gameWorld = new World();

var legolasComponents = new List<object>
{
    new Position(200,100),
    new Health(50),
    new Power(10)
};

var legolas = gameWorld.AddEntity(legolasComponents);
var tower1 = gameWorld.AddEntity(new List<object>
{
    new Position(100,0),
    new Health(200)
});
var tower2 = gameWorld.AddEntity(new List<object>
{
    new Position(0,0),
    new Health(200)
});

foreach (var kv in gameWorld.Entities)
{
    Console.WriteLine(kv.Key);
    foreach (var entity in kv.Value)
    {
        Console.WriteLine("\t{0}", entity.ToString());
    }
}

namespace Model
{
    public class World
    {
        private readonly Dictionary<Guid, List<object>> entitites = [];

        public Guid AddEntity(List<object> objects)
        {
            var id = Guid.NewGuid();
            entitites.Add(id, objects);
            return id;
        }

        public List<object> GetEntity(Guid id)
        {
            return entitites[id];
        }

        public Dictionary<Guid, List<object>> Entities
        {
            get { return entitites; }
        }

    }
    public class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"Pos ({X}:{Y})";
        }
    }

    public class Health
    {
        public int Value { get; private set; } = 100;

        public Health(int value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return $"Health ({Value})";
        }
    }

    public class Velocity
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Velocity(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"Vel ({X}:{Y})";
        }
    }

    public class Power
    {
        public int Value { get; private set; }
        public Power(int value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return $"Power ({Value})";
        }
    }
}