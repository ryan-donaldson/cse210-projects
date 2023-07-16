namespace Foundation3
{
    ///<summary>
    /// Holds the info for Outdoor Events.
    ///<summary>

    public class Outdoor : Event
    {
        private string _forecast;

        public Outdoor(string forecast, string type, string title, string description, string date, string time, Address address) : base(type, title, description, date, time, address)
        {
            _forecast = forecast;
        }

        public void FullDetails()
        {
            Console.WriteLine("Full Event Details:");
            GetDetails();
            Console.WriteLine($"Weather Forecast: {_forecast}");
        }
    }
}