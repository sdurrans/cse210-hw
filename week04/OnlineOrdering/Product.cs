using System;

class Product
{
    private string _name; 
    private string _productId; 
    private float _price;
    private int _quantity;

    public Product(string name, string productId, float price)
    {
       
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = 1;
    
    }
    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string Name
    {
        get { return _name; }
    }

    public string ProductId
    {
        get { return _productId; }
    }

    public float Price
    {
        get { return _price; }
    }

    public int Quantity
    {
        get { return _quantity; }
    }

    public float GetTotalCost()
    {
        return _price * _quantity;
    }
    public string GetPackingLabel()
    {
        return $"{_name} ({_productId})";
    }
}