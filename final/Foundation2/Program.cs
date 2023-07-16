using System;

namespace Foundation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("55 Fifty Five St.", "Concord", "Alabama", "USA");
            Customer customer1 = new Customer("John Doe", address1);
            Product cust1prod1 = new Product("Pancakes", 1092834321, 3.99, 5);
            Product cust1prod2 = new Product("Syrup", 483759384, 9.99, 2);
            Order order1 = new Order(customer1);
            order1.AddProduct(cust1prod1);
            order1.AddProduct(cust1prod2);

            Address address2 = new Address("101189 Hwy 89", "Thane", "Wyoming", "Transylvania");
            Customer customer2 = new Customer("Robert P.", address2);
            Product cust2prod1 = new Product("Wallet",543812667, 43.61, 1);
            Product cust2prod2 = new Product("Earrings", 61012111, 99.89, 3);
            Order order2 = new Order(customer2);
            order2.AddProduct(cust2prod1);
            order2.AddProduct(cust2prod2);

            Console.WriteLine("Order 1");
            order1.PackingLabel();
            order1.ShippingLabel();
            order1.GetTotalCost();
            Console.WriteLine();
            Console.WriteLine("Order 2");
            order2.PackingLabel();
            order2.ShippingLabel();
            order2.GetTotalCost();
        }
    }
}
