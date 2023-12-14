using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Address usAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Address canadaAddress = new Address("456 Maple Ave", "Townsville", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", usAddress);
        Customer customer2 = new Customer("Jane Smith", canadaAddress);

        Order order1 = new Order(customer1);
        order1.Products.Add(new Product("Product 1", 1, 10.0, 2));
        order1.Products.Add(new Product("Product 2", 2, 15.0, 1));

        Order order2 = new Order(customer2);
        order2.Products.Add(new Product("Product 3", 3, 8.0, 3));
        order2.Products.Add(new Product("Product 4", 4, 20.0, 1));

        Console.WriteLine($"Order 1 - Total Cost: {order1.CalculateTotalCost()}");
        Console.WriteLine($"Order 1 - Packaging Label: {order1.GetPackagingLabel()}");
        Console.WriteLine($"Order 1 - Shipping Label: {order1.GetShippingLabel()}");

        Console.WriteLine($"Order 2 - Total Cost: {order2.CalculateTotalCost()}");
        Console.WriteLine($"Order 2 - Packaging Label: {order2.GetPackagingLabel()}");
        Console.WriteLine($"Order 2 - Shipping Label: {order2.GetShippingLabel()}");
    }
}



