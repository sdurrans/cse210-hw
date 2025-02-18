using System;

class Program
{
    static void Main()
    {
        Address addr1 = new Address("123 West Oak Orchard st", "Medina", "NY", "USA");
        Customer cust1 = new Customer("Stuart Durrant", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Zotac NVIDIA GeForce RTX 5080", "803353", 12499.99f, 1));
        order1.AddProduct(new Product("Hyte Y70, Snow white", "HY70W", 219.99f, 1));
        order1.AddProduct(new Product("Lian Li UNI Fan SL-Infinity 120-Triple Pack","LS120INF", 99.99f, 2));
    

        Address addr2 = new Address("12397 Centerline Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Jessica Durrant", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Mission Dark Leather Chair", "300749611353", 330.99f, 1));
        order2.AddProduct(new Product("Vasagle Side Table", "C012", 26.59f, 2));
        order2.AddProduct(new Product("Dimmable Floor Lamp", "788703169476", 39.99f, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalPrice());
        Console.WriteLine();
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalPrice());
    }
}
