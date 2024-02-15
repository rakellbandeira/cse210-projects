class Product
{
    private string _prodName;
    private string _prodID;
    private double _prodPrice;

    private int _prodQuantity;
    

    public Product(string productName, string productId, double price)
    {
        _prodName = productName;
        _prodID = productId;
        _prodPrice = price;
        _prodQuantity = 0;
        
    }

    
    public string GetProdName()
    {
        return _prodName;
    }
    public string GetProdId()
    {
        return _prodID;
    }

    public double GetProdPrice()
    {
        return _prodPrice;
    }

    public void SetProdQuantity(int quantity)
    {
        _prodQuantity = quantity;
    }

    public int GetProdQuantity()
    {
        return _prodQuantity;
    }
}

