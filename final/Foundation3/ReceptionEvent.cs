namespace Foundation3
{
    ///<summary>
    /// Holds info for Reception Events.
    ///<summary>

    public class Reception : Event
    {
        private string _rsvpEmail;

        public Reception(string rsvpEmail, string type, string title, string description, string date, string time, Address address) : base(type, title, description, date, time, address)
        {
            _rsvpEmail = rsvpEmail;
        }

        public void FullDetails()
        {
            Console.WriteLine("Full Event Details:");
            GetDetails();
            Console.WriteLine($"RSVP Email: {_rsvpEmail}");
        }
    }
}