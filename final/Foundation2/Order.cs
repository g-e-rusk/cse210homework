using System;

public class Order
{
    // Member Variables
    private List<Product> _productList = new List<Product>();

    private Customer _newCustomer;

    // Constructors
    public Order(string name)
    {
        _newCustomer = new Customer(name); //Gets the name of the customer

    }

    public Order(string id, string name)
    {
        // Instantiates the product class and adds the product id and product name to the list
        Product products = new Product(id, name);
        products.GetProductName();
        products.GetProductID();
        _productList.Add(products);
    }

    // Methods
    public void GetPackingSlip()
    {    
        // Prints the customer name
        _newCustomer.SetCustomerName(name);
        // Prints the product ID and product name in a list
        foreach(Product product in _productList)
        {
            product.SetProductID();
            product.SetProductName();
        }
    }

    public void GetShippingLabel()
    {
        // Prints the customer name and instantiates the Address class from the Customer class
        _newCustomer.SetCustomerName(name);
        Customer customerAddress = new Customer();
        customerAddress.GetCustomerAddress();
    }

    public void CalculateShippingCosts()
    {

    }

}