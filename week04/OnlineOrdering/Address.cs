public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public void SetAddress(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool GetIfUSA()
    {
        bool usa = false;
        if (_country.ToLower() == "usa")
        {
            usa = true;
        }
        return usa;
    }

    public string GetFullAddress()
    {
        string fullAddress = $"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}";
        return fullAddress;
    }
}