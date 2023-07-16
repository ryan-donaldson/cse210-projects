namespace Foundation2
{
    ///<summary>
    /// The Customer class holds the info about a customer.
    ///<summary>

    public class Customer
    {
        private string _name;
        protected Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public bool LiveInUSA()
        {
            return _address.CheckCountry();
        }
        public string GetName()
        {
            return _name;
        }
        public string GetAddress()
        {
            return _address.GetAddress();
        }
    }
}