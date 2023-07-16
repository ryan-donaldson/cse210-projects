namespace Foundation3
{
    ///<summary>
    /// Holds the address for the event.
    ///<summary>

    public class Address
    {
        private string _address;

        public Address(string address)
        {
            _address = address;
        }

        public string GetAddress()
        {
            return _address;
        }
    }
}