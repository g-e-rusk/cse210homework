using System;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer("Carolyn Brown");
        c1.SetCustomerName();
        Customer c2 = new Customer("123 Main Street, Avocadodale, MI, USA");
        c2.GetCustomerAddress();

        
    }
}