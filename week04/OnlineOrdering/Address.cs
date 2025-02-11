using System;

class Address
{
    private string Street;
    private string City;
    private string State;
    private string Country;

    public Address(string street, string city, string state, string country)

    
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    
    }

    public bool IsInUSA()
    {
        if(Country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}