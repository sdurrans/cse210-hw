using System;
using System.Collections.Generic;

class Order
{
    private List<Product> Products;
    private Customer Customer;
    private const decimal USA_SHIPPING_COST = 5m;
    private const decimal INTERNATIONAL_SHIPPING_COST = 35m;

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
       Products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }
        total += Customer.IsInUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
         return $"Shipping To: {Customer.GetName()}\n{Customer.GetAddress().GetFullAddress()}";
    }
}
