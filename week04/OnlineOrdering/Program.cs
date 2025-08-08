using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("\n OnlineOrdering Project.");
        /*Once you have created these classes, write a program that creates at least two orders 
        with a 2-3 products each. Call the methods to get the packing label, the shipping label, 
        and the total price of the order, and display the results of these methods.*/
        Address address1 = new Address();
        address1.SetStreet("456 Oak Avenue");
        address1.SetCity("Springfield");
        address1.SetState("NY");
        address1.SetCountry("United States");

        Customer customer1 = new Customer("Phill Crandall", address1);
        Order order1 = new Order(customer1);
        Product p1 = new Product();
        p1.SetId(1);
        p1.SetName("Icecream");
        p1.SetPrice(2.24);
        p1.SetQuantity(3);

        order1.AddProduct(p1);
        Product p2 = new Product();
        p2.SetId(2);
        p2.SetName("Bread");
        p2.SetPrice(0.5);
        p2.SetQuantity(10);
        order1.AddProduct(p2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("_____________________________________________");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("_____________________________________________");
        double totalCost = order1.GetTotalCost();
        Console.WriteLine("Total Price: $" + totalCost);

        Console.WriteLine("\n");
        Address address2 = new Address();
        address2.SetStreet("1850 Kollasuyo Avenue");
        address2.SetCity("La Paz");
        address2.SetState("Nuestra Señora de La Paz");
        address2.SetCountry("Bolivia");

        Customer customer2 = new Customer("Jazmin Ruiz", address1);
        Order order2 = new Order(customer2);
        Product p3 = new Product();
        p3.SetId(63);
        p3.SetName("Coat");
        p3.SetPrice(50.25);
        p3.SetQuantity(1);
        order2.AddProduct(p3);

        Product p4 = new Product();
        p4.SetId(89);
        p4.SetName("Scarf");
        p4.SetPrice(10);
        p4.SetQuantity(2);
        order2.AddProduct(p4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("_____________________________________________");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("_____________________________________________");
        double totalCost2 = order2.GetTotalCost();
        Console.WriteLine("Total Price: $" + totalCost2);

    }
}