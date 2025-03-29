// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System\n");

        // Create addresses
        Address usaAddress = new Address("123 Main St", "Seattle", "WA", "USA");
        Address internationalAddress = new Address("456 Maple Ave", "Toronto", "Ontario", "Canada");

        // Create customers
        Customer usaCustomer = new Customer("John Smith", usaAddress);
        Customer internationalCustomer = new Customer("Emily Johnson", internationalAddress);

        // Create products
        Product laptop = new Product("Gaming Laptop", "PROD-001", 999.99m, 1);
        Product headphones = new Product("Wireless Headphones", "PROD-002", 149.99m, 2);
        Product mouse = new Product("Gaming Mouse", "PROD-003", 59.99m, 1);
        Product keyboard = new Product("Mechanical Keyboard", "PROD-004", 129.99m, 1);
        Product monitor = new Product("27-inch Monitor", "PROD-005", 249.99m, 2);

        // Create first order (USA)
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(laptop);
        order1.AddProduct(headphones);
        order1.AddProduct(mouse);

        // Create second order (International)
        Order order2 = new Order(internationalCustomer);
        order2.AddProduct(keyboard);
        order2.AddProduct(monitor);

        // Display Order 1 details
        Console.WriteLine("ORDER #1");
        Console.WriteLine("--------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        // Display Order 2 details
        Console.WriteLine("ORDER #2");
        Console.WriteLine("--------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotalCost():F2}");
    }
}