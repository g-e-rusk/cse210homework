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

    public Customer(string name)
    {
        _customerName = name;
    }

    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    // Methods
    public void GetCustomerAddress()
    {
        _customerAddress.GetAddress();
    }

    public void GetCustomerCountry()
    {
        _customerAddress.GetCountry();
    }


}