using System;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double GetTotal()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            double productTotal = product.GetTotal();
            total += productTotal;
        }
        if (_customer.isUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} {product.GetProductId()}");
        }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"\n{_customer.GetName()}\n{_customer.GetAddress().DisplayAddress()}";
        return shippingLabel;
    }

}