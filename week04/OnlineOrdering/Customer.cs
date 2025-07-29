public class Customer
{
    private string _customerName;
    Address _customerAdress = new Address();

    public void SetCustomerInformation(string customerName, string streetAddress, string city, string stateOrProvince, string country)
    {
        _customerName = customerName;
        _customerAdress.SetAddress(streetAddress, city, stateOrProvince, country);
    }
    public bool GetIfInUSA()
    {
        bool usa = _customerAdress.GetIfUSA();
        return usa;
    }
    public string GetCustomerName()
    {
        string customerName = _customerName;
        return customerName;
    }
    public string GetCustomerFullAddress()
    {
        string customerFullAddress = _customerAdress.GetFullAddress();
        return customerFullAddress;
    }
}