using System;
using System.Collections.Generic;

class Order
{
    private List<Product> Products;
    private Customer _customer;
  
    public Order(Customer customer)
    {
        _customer = customer;
        Products = new List<Product>();       
    }

    public void GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in Products)
        {
            totalCost += product.GetTotalCost();
        }

        decimal shippingCost = 0;   
        return totalCost + shippingCost;
    }

    public  void GetPackingLabel()
    {
       string packingLabel = "";
         foreach(Product product in Products)
         {
              packingLabel += $"{product.GetName()} ({product.GetProductId()})\n";
         }
         return packingLabel;
    }

    public void GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}
