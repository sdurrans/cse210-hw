using System;

class Customer
{
   public string Name;
    public Address Address;

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }


    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }

    public string GetName()
    {
        return Name;
    }
    public Address GetAddress() 
    {
        return Address;
    }
}