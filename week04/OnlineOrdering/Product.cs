public class Product
{
    private string _productName;
    private string _productId;
    private float _productPrice;
    private int _productQuantity;

    public void SetProduct(string productName, string productId, string productPrice, string productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = float.Parse(productPrice);
        _productQuantity = int.Parse(productQuantity);
    }
    public float GetTotalCost()
    {
        float totalCost = _productPrice * _productQuantity;
        return totalCost;
    }
    public string GetNameAndId()
    {
        string nameAndId = $"{_productId}-{_productName}";
        return nameAndId;
    }
}