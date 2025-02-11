using System;

class Product
{
    public string Name; 
    public string ProductId; 
    public decimal Price;
    public int Quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
       
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    
    }

    public decimal GetTotalCost()
    {
        
    }

    public string GetName() 
    {
        
    }
    public string GetProductId() 
    {   
        
    }
}