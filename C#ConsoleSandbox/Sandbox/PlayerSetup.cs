namespace Sandbox
{
    public class PlayerSetup
    {
        public Player Player { get; set; }

        public PlayerSetup()
        {
            Player = new Player();
        }

        public void GetPlayerInfo()
        {
            Console.WriteLine("What is your name?");
            Player.Name = Console.ReadLine();
            bool waiting = true;
            while (waiting)
            {
                Console.WriteLine("What is your age?");
                string ageInput = Console.ReadLine();

                try
                {
                    Player.Age = int.Parse(ageInput);
                    waiting = false;
                }
                catch
                {
                    Console.WriteLine($"{ageInput} is not a number.");
                }
            }

            waiting = true;

            while (waiting)
            {

                Console.WriteLine("How fast are you?");
                string speedInput = Console.ReadLine();
                string validValues = "1, 2, or 3";

                try
                {
                    int speedInteger = int.Parse(speedInput);
                    if (isSpeedValid(speedInteger))
                    {
                        waiting = false;
                        Player.Speed = (SpeedType)speedInteger;
                    }
                    else
                    {
                        Console.WriteLine($"{speedInput} is not valid. Valid values are {validValues}");
                    }
                }
                catch
                {
                    Console.WriteLine($"{speedInput} is not a number. Valid values are {validValues}");
                }
            }
        }

        private bool isSpeedValid(int speed)
        {
            return speed > 0 && speed < 4;
        }
    }
}
