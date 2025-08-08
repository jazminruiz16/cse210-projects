/*The address contains a string for the street address, the city, state/province, and country.

La dirección debe tener un método que pueda devolver si está en EE. UU. o no.
La dirección debe tener un método para devolver una cadena con todos sus campos juntos en una cadena 
(con caracteres de nueva línea cuando corresponda).*/

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetStreet()
    {
        return _street;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public string GetState()
    {
        return _state;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetCountry()
    {
        return _country;
    }
    public bool GetCountryEEUU()
    {
        if (_country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        string fullAddress = $"{_street}\n {_city}, {_state},\n {_country}";
        return fullAddress;
    }

}