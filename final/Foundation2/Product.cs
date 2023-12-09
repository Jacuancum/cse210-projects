class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    //Create Product variable then add all the related attributes into it
    public Product(string name, int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //Create CalculateTotalPrice method then assign a formula with attributes then return the result to the method
    public decimal CalculateTotalPrice()
    {
        return _price * _quantity;
    }

    //Create GetName method then assign a attributes then return the result to the method
    public string GetName()
    {
        return _name;
    }

    //Create GetProductId method then assign a attributes then return the result to the method
    public int GetProductId()
    {
        return _productId;
    }
}