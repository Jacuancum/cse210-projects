using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressIntl1 = new Address("56 Cornwall St.", "Kowloon Tong", "Kowloon", "Hong Kong");
        Customer customerIntl1 = new Customer("Tim Cook", addressIntl1);

        Address addressIntl2 = new Address("78 Tung Mei Street", "Tai O", "Lantau Isaland", "Hong Kong");
        Customer customerIntl2 = new Customer("Bella Chan", addressIntl2);

        Address addressUSA1 = new Address("90 Hardworking Road", "Justdoit Town", "Dream State", "USA");
        Customer customerUSA1 = new Customer("Tony Jarhgs", addressUSA1);

        Product product1 = new Product("Toilet paper", 00201, 60.50m, 2);
        Product product2 = new Product("Fozen pizza", 00101, 95.99m, 2);
        Product product3 = new Product("Cokecola", 00301, 0.49m, 12);
        Product product4 = new Product("1 pack of 6 Egg", 00401, 29.99m, 2);

        Order order1 = new Order(customerIntl1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customerIntl2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customerUSA1);
        order3.AddProduct(product3);
        order3.AddProduct(product4);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 3:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Total Price: ${order3.CalculateTotalCost()}");
    }
}