namespace Foundation3
{
    ///<summary>
    /// Holds the info for Lecture Events.
    ///<summary>

    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string speaker, int capacity, string type, string title, string description, string date, string time, Address address) : base(type, title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public void FullDetails()
        {
            Console.WriteLine("Full Event Details:");
            Console.WriteLine($"Speaker: {_speaker} - Capacity: {_capacity}");
            GetDetails();
        }
    }
}