using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = [];
        Address kayodeAddress = new("Block 5 plot 2", "Ado-Ekiti", "Ekiti State", "Nigeria");
        Customer kayode = new("Kayode Adetayo", kayodeAddress);
        Order kayodeOrder = new(kayode);
        Address tosingAddress = new("Block 10 plot 21", "Ado-Ekiti", "Ekiti State", "Nigeria");
        Customer tosin = new("Tosin Ogunojemite", tosingAddress);
        Order tosinOrder = new(tosin);

        kayodeOrder.AddProduct("potato", 1, 12.40m, 30);
        kayodeOrder.AddProduct("Standing Fan", 15, 32.40m, 30);
        kayodeOrder.AddProduct("Air fresher", 21, 132.40m, 30);
        kayodeOrder.AddProduct("Oroki slice Bread", 332, 122.40m, 30);
        tosinOrder.AddProduct("540ml Bayern Mayonnaise", 101, 1223.40m, 30);
        tosinOrder.AddProduct("5L Sunshine Vegetable Oil", 192, 122.40m, 30);
        tosinOrder.AddProduct("2kg Bell Peper", 601, 1232.40m, 30);
        tosinOrder.AddProduct("5L Sunshine Palm Oil", 98, 122.40m, 30);

        orders.Add(kayodeOrder);
        orders.Add(tosinOrder);

        foreach (var order in orders)
        {
            Console.WriteLine($"Order Details for {order.CustomerName()}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(order.PackagingLabel());
            Console.WriteLine("");
            Console.WriteLine($"Order Cost: {order.OrderCost():C}");
            Console.WriteLine($"Total Cost {order.TotalCost():C}");
            Console.WriteLine("");
            Console.WriteLine("Shipping Address");
            Console.WriteLine($"{order.ShippingLabel()}");
            Console.WriteLine("");
        }
    }
}