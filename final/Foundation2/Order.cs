class Order
{
    private double _shippingCost;
    private double _totalPrice = 0;

    private int _quantity = 0;
    List<Product> productList;
    Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
        productList = new List<Product>();
    }

    public void AddProduct(Product product, int quantity)
    {
        product.SetProdQuantity(quantity);
        productList.Add(product);
    }

    public double TotalCostPerProduct(Product product)
    {
        double price = product.GetProdPrice();
        int quantity = product.GetProdQuantity();

        return price * _quantity;
    }


    public double TotalPrice()
    {
        if (_customer.GetUsaOrNot())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }

        _totalPrice +=_shippingCost;

        foreach(Product prod in productList)
        {
            _totalPrice += TotalCostPerProduct(prod);
        
        }

        return _totalPrice;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("\nPacking Labels:");
        foreach (Product prod in productList)
        {
            Console.WriteLine($"\t{prod.GetProdName()} - ID:{prod.GetProdId()}");
        }

    }

    public void GetShippingLabel()
    {
       
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine($"\t{_customer.GetName()} \n{_customer.DisplayAddress()}");
    }
}