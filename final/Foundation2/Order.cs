namespace Foundation2
{
    ///<summary>
    /// The Order class lets us see everything about an order
    ///<summary>

    public class Order
    {
        private Customer _customer;
        private List<Product> _products;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void GetTotalCost()
        {
            double shippingCost = 0;
            if(_customer.LiveInUSA())
            {
                shippingCost += 5;
            }
            else
            {
                shippingCost += 35;
            }
            foreach(Product product in _products)
            {
                shippingCost += product.TotalPrice();
            }

            Console.WriteLine($"Total Order Cost: ${Math.Round(shippingCost, 3)}");
        }
        public void ShippingLabel()
        {
            Console.WriteLine("Shipping Label: ");
            Console.WriteLine(_customer.GetName());
            Console.WriteLine(_customer.GetAddress());
        }
        public void PackingLabel()
        {
            Console.WriteLine("Packing Label: ");
            foreach(Product product in _products)
            {
                Console.WriteLine($"{product.GetName()} - {product.GetProductId()}");
            }
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}