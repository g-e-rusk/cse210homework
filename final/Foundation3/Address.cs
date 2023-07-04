using System;

public class Address
{
    // Private Member Variables
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructors
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }

    // Methods
    public string GetAddressDisplay()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince} {_country}";
    }
}