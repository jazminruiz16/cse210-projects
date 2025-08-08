/*The customer contains a name and an address.

The name is a string, but the Address is a class.
The customer should have a method that can return whether they live in the USA or not. 
(Hint this should call a method on the address to find this.) La dirección debe tener 
un método para devolver una cadena con todos sus campos juntos en una cadena (con caracteres de nueva línea cuando corresponda).*/

public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
    public bool LivesInUSA()
    {
        return _address.GetCountryEEUU();
    }
}