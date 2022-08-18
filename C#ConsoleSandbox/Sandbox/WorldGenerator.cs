namespace Sandbox
{
    public class WorldGenerator
    {
        public List<Room> Rooms { get; set; }

        public int CurrentRoom { get; set; }

        public WorldGenerator()
        {
            Rooms = new List<Room>();
            Rooms.Add(new Room());
            Rooms.Add(new Room());
            CurrentRoom = 0;
        }

        public void Move()
        {
            if (CurrentRoom + 1 > Rooms.Count - 1)
                Console.WriteLine("There are no more rooms.");
            else
                CurrentRoom = ++CurrentRoom;
        }

        public void DescribeRoom()
        {
            Console.WriteLine(Rooms[CurrentRoom].Description);
        }

        public void Look()
        {
            string animals = "";
            foreach (var animal in Rooms[CurrentRoom].Animals)
            {
                animals += $" {animal}";
            }
            Console.WriteLine($"You see: {animals}");
        }

    }
}
