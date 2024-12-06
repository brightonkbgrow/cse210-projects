using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 n 456 w", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Brighton G", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Resin DnD Dice", "0001", 24.99m, 1));
        order1.AddProduct(new Product("12/8oz Glass bottles", "0002", 12.99m, 3));

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine();

        Address address2 = new Address("987 madeup st", "Rexburg", "ID", "USA");
        Customer customer2 = new Customer("Cami E", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Lego Tuxedo Cat", "0003", 84.99m, 1));
        order2.AddProduct(new Product("10lb bag of cat food", "0004", 19.99m, 4));

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Price: ${order2.GetTotalPrice()}");

                Console.WriteLine();

        Address address3 = new Address("THE NORTH POLE", "North", "Pole", "NorthPole");
        Customer customer3 = new Customer("Santa C", address3);

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("elf sized shock collars", "0005", 10.00m, 1000));
        order3.AddProduct(new Product("1000 sq ft Wrapping Paper", "0006", 99.99m, 200));

        Console.WriteLine("Order 3 Packing Label:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("Order 3 Shipping Label:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Order 3 Total Price: ${order3.GetTotalPrice()}");
    }
}
