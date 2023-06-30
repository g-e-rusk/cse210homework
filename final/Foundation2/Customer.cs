using System;

public class Customer
{
    // Member Variables
    private string _customerName;
    private Address _customerAddress = new Address();

    // Constructors
    public Customer()
    {
    }

    // public Customer(string name)
    // {
    //     _customerName = name;
    // }

    // public Customer(Address _customerAddress)
    // {
    //     _customerAddress = new Address();
    //     _customerAddress.SetAddress(street, city, state, country);
        

    // }

    // Methods
    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerName(string name)
    {
        _customerName = name;
    }

    public void GetCustomerAddress()
    {
        Address _customerAddress = new Address();
        _customerAddress.SetAddress(street, city, state, country);
    }

    public void GetCustomerCountry()
    {
        _customerAddress.GetCountry();
    }


}