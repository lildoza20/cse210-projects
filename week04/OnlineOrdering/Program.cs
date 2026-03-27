using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("742 Maple Street", "Phoenix", "AZ", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM101", 24.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "MK202", 70.50, 1));
        order1.AddProduct(new Product("USB-C Cable", "UC303", 9.99, 3));
        orders.Add(order1);

        Address address2 = new Address("18 King Street West", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "NB404", 4.50, 5));
        order2.AddProduct(new Product("Desk Lamp", "DL505", 32.99, 1));
        order2.AddProduct(new Product("Backpack", "BP606", 45.00, 1));
        orders.Add(order2);

        Address address3 = new Address("55 Oak Avenue", "Dallas", "TX", "United states");
        Customer customer3 = new Customer("Michael Brown", address3);

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Water Bottle", "WB707", 15.75, 2));
        order3.AddProduct(new Product("Bluetooth Speaker", "BS808", 64.99, 1));
        order3.AddProduct(new Product("Phone Charger", "PC909", 18.25, 2));
        orders.Add(order3);

        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"Order #{orderNumber}");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
            orderNumber += 1;

            Console.WriteLine();
        }
    }
}