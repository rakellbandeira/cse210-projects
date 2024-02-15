class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool GetUsaOrNot()
    {
        return _address.IsUsa();
    }

    public string DisplayAddress()
    {
        return _address.DisplayAddress();
    }

    public string GetName()
    {
        return _name;
    }




}