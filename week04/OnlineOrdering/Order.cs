using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;
  
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();       
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float CalculateTotalPrice()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        return total + ShippingCost();
    }

    public float ShippingCost()
    {
        if (_customer.GetAddress().GetCountry() == "USA")
        {
            return 5.00f;
        }
        else
        {
            return 35.00f;
        }
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetPackingLabel() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return _customer.DisplayCustomer();
    }
}

