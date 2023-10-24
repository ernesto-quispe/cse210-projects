class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public void GetPacking()
    {   
        Console.WriteLine("Packaging items: ");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product Name: {product.GetProductName()} Product id: {product.GetProductId()} Quantity: {product.GetQuantity()}");
        }
    }
    public void GetShipping()
    {
        Console.WriteLine("\nShipping information: ");
        Console.WriteLine($"Customer: {_customer.GetName()}");
        Console.WriteLine($"Address: {_customer.GetFullAddress()}");
    }
    private void GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }
        if (_customer.IsUsa())
        {
           totalCost += 5;
        }
        else 
        {
           totalCost += 35;
        }
        Console.WriteLine($"Total cost: ${totalCost}");
    }
    public void DisplayInfo()
    {
       GetPacking();
       GetShipping();
       GetTotalCost();
    }
}