class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;
    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _name;
    }
    public int GetProductId()
    {
        return _productId;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}