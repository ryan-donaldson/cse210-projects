namespace Foundation3
{
    ///<summary>
    /// Holds the base values and methods for all Events.
    ///<summary>

    public class Event
    {
        private string _type;
        private string _title;
        private string _description;
        private string _date;
        private string _time;
        private Address _address;

        public Event(string type, string title, string description, string date, string time, Address address)
        {
            _type = type;
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        public void GetDetails()
        {
            Console.WriteLine($"{_title} - {_description}");
            Console.WriteLine($"{_date} - {_time}");
            Console.WriteLine($"{_address.GetAddress()}");
        }

        public void ShortDesc()
        {
            Console.WriteLine("Short Description:");
            Console.WriteLine($"Event Type: {_type} - Title: {_title} - Date: {_date}");
        }

    }
}