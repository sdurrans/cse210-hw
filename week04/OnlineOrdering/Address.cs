using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)


    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetFullAddress()
    {
        if (IsInUSA())
        {
            return $"{_street}, {_city}, {_state}";
        }
        else
        {
            return $"{_street}, {_city}, {_state}, {_country}";
        }
    }

    public string GetCountry()
    {
        return _country;
    }
}