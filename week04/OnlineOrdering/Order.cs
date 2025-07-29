public class Order
{
    Customer _customer = new Customer();
    private List<Product> _productList = new List<Product>();

    public void SetCustomerInformation(string customerName, string streetAddress, string city, string stateOrProvince, string country)
    {
        _customer.SetCustomerInformation(customerName, streetAddress, city, stateOrProvince, country);
    }
    public void AddProduct(string productName, string productId, string productPrice, string productQuantity)
    {
        Product product = new Product();
        product.SetProduct(productName, productId, productPrice, productQuantity);
        _productList.Add(product);
    }
    public float CalculateTotalCost()
    {
        float totalProductCost = 0;
        foreach (Product p in _productList)
        {
            totalProductCost += p.GetTotalCost();
        }
        return totalProductCost;
    }
    public string GetShippingLabel()
    {
        string customerName = _customer.GetCustomerName();
        string fullAddress = _customer.GetCustomerFullAddress();
        string shippingLabel = $"{customerName} - {fullAddress}";
        return shippingLabel;
    }
    public List<string> GetPackingLabel()
    {
        List<string> _packingLabel = new List<string>();
        foreach (Product p in _productList)
        {
            string nameAndId = p.GetNameAndId();
            _packingLabel.Add(nameAndId);
        }
        return _packingLabel;
    }
    public int GetShippingCost()
    {
        int shippingCost = 0;
        bool usa = _customer.GetIfInUSA();
        if (usa == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
    public float CalculateFinalPrice()
    {
        float productsCost = CalculateTotalCost();
        int shippingCost = GetShippingCost();
        float finalPrice = productsCost + shippingCost;
        return finalPrice;
    }
}