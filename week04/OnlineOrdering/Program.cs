using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new("Block 5 plot 2", "Ado-Ekiti", "Ekiti State", "Nigeria");
        Customer customer = new("Kayode Adetayo", address);
        Order order = new(customer);

        order.AddProduct("potato", 1, 12.40m, 30);
        order.AddProduct("Standing Fan", 15, 32.40m, 30);
        order.AddProduct("Air fresher", 21, 132.40m, 30);
        order.AddProduct("Oroki slice Bread", 332, 122.40m, 30);
        order.AddProduct("540ml Bayern Mayonnaise", 101, 1223.40m, 30);
        order.AddProduct("5L Sunshine Vegetable Oil", 192, 122.40m, 30);
        order.AddProduct("2kg Bell Peper", 601, 1232.40m, 30);
        order.AddProduct("5L Sunshine Palm Oil", 98, 122.40m, 30);

        Console.WriteLine(order.PackagingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Order Cost: {order.OrderCost():C}");
        Console.WriteLine("");
        Console.WriteLine($"Total Cost {order.TotalCost():C}");
        Console.WriteLine("");
        Console.WriteLine($"{order.ShippingLabel()}");
    }
}