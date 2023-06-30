using System;

public class Product
{
    // Member variables
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;

    // Constructors
    public Product()
    {
    }

    public Product(string name, string id)
    {
        _productName = name;
        _productID = id;
    }

    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productID = id;
        _productPrice = price;
        _productQuantity = quantity;
    }

    // Methods
    public double GetSubtotalPrice()
    {
        return _productPrice * _productQuantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductName()
    {
        Console.WriteLine(GetProductName());
    }

    public string GetProductID()
    {
        return _productID + "";
    }

    public void SetProductID()
    {
        Console.Write(GetProductID());
    }

}