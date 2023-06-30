using System;

public class Address
{
    // Member Variables
    private string _streetAddress {get; set;}
    private string _city {get; set;}
    private string _stateOrProvince {get; set;}
    private string _country {get; set;}

    // Constructors
    public Address()
    {
    }

    // Methods (Getters and Setters)
    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
        
    }


}