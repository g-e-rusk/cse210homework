using System;

public class Address
{
    // Member Variables
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructors
    public Address()
    {
    }

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }

    // Methods
    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry()
    {
        Console.WriteLine(GetCountry());
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }

    public void SetAddress()
    {
        Console.WriteLine(GetAddress());
    }


}