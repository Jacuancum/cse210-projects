class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        if (_customer.InsideUSA())
        {
            totalCost += 5; // USA shipping cost
        }
        else
        {
            totalCost += 35; // International shipping cost
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "[Packing Label]\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        Customer customer = _customer;
        Address address = customer.GetAddress();

        string label = "[Shipping Label]\n";
        label += $"Name: {customer.GetName()}\n";
        label += $"Address:\n{address.GetFullAddress()}";

        return label;
    }
}