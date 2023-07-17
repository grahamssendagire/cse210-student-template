using System;

class Program
    {
        static void Main(string[] args)
        {
            // create a customer
            var address = new Address("123 Main St", "Anytown", "CA", "USA");
            var customer = new Customer("John Doe", address);

            // create a product
            var product1 = new Product("Widget A", 123, 2.99, 3);

            // create an order with one product
            var order1 = new Order(customer);
            order1.AddProduct(product1);

            // create another product
            var product2 = new Product("Widget B", 456, 4.99, 2);

            // create another order with two products
            var order2 = new Order(customer);
            order2.AddProduct(product1);
            order2.AddProduct(product2);

            // display order details
            Console.WriteLine("Order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total price: {order1.GetTotalCost():C}");

            Console.WriteLine();
            Console.WriteLine("Order 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total price: {order2.GetTotalCost():C}");
        }
    }

