// Address.cs
using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetStateProvince()
    {
        return _stateProvince;
    }

    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public bool IsInUSA()
    {
        // Check if the country is USA (case insensitive)
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES" || _country.ToUpper() == "UNITED STATES OF AMERICA";
    }

    public string GetFormattedAddress()
    {
        // Return a formatted string of the address
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}
