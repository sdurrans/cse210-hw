using System;

class Product
{
    public string Name { get; }  
    public string ProductId { get; }  
    public decimal Price { get; }  
    public int Quantity { get; } 

    public Product(string name, string productId, decimal price, int quantity)
    {
       
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    
    }

    public decimal GetTotalCost()
    {
        return Price * Quantity;
        
    }

    public string GetName() => Name;
    public string GetProductId() => ProductId;
}