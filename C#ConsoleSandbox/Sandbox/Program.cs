namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Player setup
            var playerSetup = new PlayerSetup();
            playerSetup.GetPlayerInfo();
            var player = playerSetup.Player;

            //World setup
            //Game Loop
            string ageString = player.Age > 18 ? $"{player.Age} is old." : $"{player.Age} is young.";
            Console.WriteLine($"Hi, {player.Name}.  {ageString} Wow, you're {player.Speed}!");

            var world = new WorldGenerator();

            Console.WriteLine("You enter the dungeon.");

            bool enteredRoom = true;
            bool running = true;

            do
            {
                if (enteredRoom)
                {
                    world.DescribeRoom();
                    enteredRoom = false;
                }
                else
                {
                    string input = Console.ReadLine();
                    if (input == "move")
                    {
                        world.Move();
                        enteredRoom = true;
                    }
                    else if (input == "look")
                    {
                        world.Look();
                    }
                    else if (input == "exit")
                    {
                        running = false;
                    }
                }
            } while (running);


            Console.WriteLine("Thanks for playing, press any key to quit...");

            Console.ReadKey();
        }
    }
}