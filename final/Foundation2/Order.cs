using System;
using System.Collections.Generic;

public class Order
{
    // Member Variables
    private List<Product> _productList = new List<Product>();

    private Customer _customer;

    // Constructors
    public Order(string customerName, string street, string city, string state, string country)
    {
        Address address = new Address(street, city, state, country); // Instantiates the Address class
         _customer = new Customer(customerName, address); //Gets the name of the customer
    }

    // Methods
    public void PrintPackingSlip()
    {    
        // Prints the product ID and product name in a list
        Console.WriteLine("Click and Ship Packing List:");
        foreach(Product product in _productList)
        {
            Console.WriteLine($"{product.GetProductID()}: {product.GetProductName()} ({product.GetProductQuantity()})");
        }
    }

    public void PrintShippingLabel()
    {
        // Prints the customer name and instantiates the Address class from the Customer class
        Console.WriteLine("Click and Ship Shipping Label: ");
        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine(_customer.GetCustomerAddress().GetAddress());
    }

    public double CalculateShippingCosts()
    {
        // Checks to see the customer country and returns the correct shipping amount
        if (_customer.GetCustomerAddress().GetCountry())
            return 5;
        else
            return 35;
    }

    public double TotalOrderPrice()
    {
        double productOrder = 0 + CalculateShippingCosts(); 
        foreach(Product product in _productList)
        {
            productOrder += product.GetSubtotalPrice();
        }


        return Math.Round(productOrder, 2);
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _productList.Add(product);
    }



}