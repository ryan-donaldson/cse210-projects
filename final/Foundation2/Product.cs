namespace Foundation2
{
    ///<summary>
    /// The Product class holds all the info about a prodcut
    ///<summary>

    public class Product
    {
        private string _name;
        private int _productId;
        private double _price;
        private int _quantity;

        public Product(string name, int productId, double price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        public double TotalPrice()
        {
            return _price * _quantity;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetProductId()
        {
            return _productId;
        }
    }
}