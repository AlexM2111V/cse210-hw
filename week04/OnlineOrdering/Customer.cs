using System;
using System.Reflection.Metadata.Ecma335;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public Boolean isUSA()
    {
        if (_address.GetCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}