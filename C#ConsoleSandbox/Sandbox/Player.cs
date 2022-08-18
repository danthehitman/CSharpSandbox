namespace Sandbox
{
    public enum SpeedType
    {
        Slow = 1,
        Medium = 2,
        Fast = 3
    }

    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public SpeedType Speed { get; set; }

        public Player()
        {

        }

        public Player(string name, int age, SpeedType speed)
        {
            Name = name;
            Age = age;
            Speed = speed;
        }

        public void Parse()
        {
            Console.WriteLine("I'm parsings stuff.");
        }
    }
}
