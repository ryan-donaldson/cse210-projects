namespace Develop04
{
    /// <summary>
    /// The responsibility of an Activity is to hold and dipslay info about activities for the user to do
    /// <summary>
    public class Activity
    {
        private string _activityName;
        private string _activityDesc;
        
        public void SetName(string name)
        {
            _activityName = name;
        }
        public string GetName()
        {
            return _activityName;
        }
        public void SetDesc(string desc)
        {
            _activityDesc = desc;
        }
        public string GetDesc()
        {
            return _activityDesc;
        }
        public int Duration { get; private set; }
        public void StartMsg()
        {
            Console.WriteLine($"Welcome to the {_activityName}!");
            Console.WriteLine($"{_activityDesc}");
            Console.WriteLine("How many seconds would you like to spend on this activity?");
            string duration = Console.ReadLine();
            Duration = int.Parse(duration);
            Console.WriteLine("Prepare to begin.");
            Pause();
        }
        public void EndMsg()
        {
            Console.WriteLine("Good job!");
            Pause();
            Console.WriteLine($"You have just completed the {_activityName}.");
            Console.WriteLine($"You spent {Duration} seconds on it.");
            Pause();
            Console.WriteLine("Goodbye!");
        }
        public void Pause()
        {
            for (int i = 2; i > 0; i--)
            {
                Console.Write("+");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("-");
            }
        }


    }
}