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

    public decimal GetTotalCost()
    {
       decimal total = 0;
         foreach(Product product in Products)
         {
              total += product.GetTotalPrice();
         }
         if(_customer.IsInUSA())
         {
             shippingCost = 5;
         }
         else
         {
             shippingCost = 10;
         }
            return total + shippingCost;
    }

    public string GetPackingLabel()
    {
       string packingLabel = "";
         foreach(Product product in Products)
         {
              packingLabel += product.GetPackingLabel();
         }
         return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}
