class Program
{
    static void Main(string[] args)
    {
       Customer customer = new Customer("Joshua Owen");
       customer.AddAddress("3324 Raby Road", "Farmington", "Missouri", "usa");
       List<Product> products = new List<Product>();
       products.Add(new Product("Alternator", 100, 76.99, 1));
       products.Add(new Product("Air Filter", 101, 32.99, 2));
       products.Add(new Product("Brake Pads, Front", 102, 106.99, 2));
       products.Add(new Product("Brake Lines 10 feet", 103, 10.99, 2));
       Order order = new Order(customer, products);
       order.DisplayInfo();
       Console.WriteLine("#######################################");

       Customer customer2 = new Customer("Milo Jury");
       customer2.AddAddress("85 E 5th St", "Winnemucca", "Nevada", "usa");
       List<Product> products2 = new List<Product>();
       products2.Add(new Product("Iphone 14", 1801, 989.99, 1));
       products2.Add(new Product("Cable, Fast Charge, 1 meter", 1803, 17.99, 2));
       products2.Add(new Product("Charger 10 watt", 1837, 32.99, 2));
       products2.Add(new Product("Case Iphone 14, Red", 1872, 45.99, 2));
       Order order2 = new Order(customer2, products2);
       order2.DisplayInfo();
       Console.WriteLine("#######################################");

       Customer customer3 = new Customer("Luisa Quispe");
       customer3.AddAddress("1774 Hernando De Magallanes", "Santiago", "RM", "Chile");
       List<Product> products3 = new List<Product>();
       products3.Add(new Product("Lipstick, Red, Maybeline", 001, 35.99, 1));
       products3.Add(new Product("Eyeliner, Dark Grey, Fine point", 089, 17.99, 2));
       products3.Add(new Product("Eye Shadow, Electric Blue", 099, 232.99, 2));
       products3.Add(new Product("Makeup Case", 057, 77.99, 2));
       Order order3 = new Order(customer3, products3);
       order3.DisplayInfo();

    }
}