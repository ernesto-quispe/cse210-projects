class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
    public bool IsUsa()
    {
        return _address.IsUsa();  
    }
    public void AddAddress(string streetAddress, string city, string stateProvince, string country)
    { 
      _address = new Address(streetAddress, city, stateProvince, country);
    }
}