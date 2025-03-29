using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Guayaquil St. 234", "Miraflores", "Lima", "Perú");
        Address address2 = new Address("100 N 230 W", "Provo", "Utah", "USA");
        Customer customer1 = new Customer("Jorge Nuñez", address1);
        Customer customer2 = new Customer("Madie Wilson", address2);
        Product product1 = new Product("Laptop", "P00001", 800, 1);
        Product product2 = new Product("Smart Watch", "P00002", 250.99, 2);
        Product product3 = new Product("Phone Case", "P00003", 10, 3);
        Product product4 = new Product("Mouse", "P00004", 22.2, 3);
        Product product5 = new Product("Keyboard", "P00005", 23.5, 10);
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        order1.AddProduct(product1);
        order1.AddProduct(product4);
        order1.AddProduct(product5);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetShippingLabel());
        order1.GetPackingLabel();
        Console.WriteLine($"Total ${order1.GetTotal()}");

        Console.WriteLine(order2.GetShippingLabel());
        order2.GetPackingLabel();
        Console.WriteLine($"Total ${order2.GetTotal()}");

    }
}