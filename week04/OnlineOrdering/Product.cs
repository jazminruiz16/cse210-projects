/*Contains the name, product id, price, and quantity of each product.

The total cost of this product is computed by multiplying the price per unit and the quantity. 
(If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)*/
public class Product
{
    private int _id;
    private string _name;
    private double _price;
    private int _quantity;
    public void SetId(int id)
    {
        _id = id;
    }
    public int GetId()
    {
        return _id;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetCostPerProduct()
    {
        double totalCost = _quantity * _price;
        return totalCost;
    }

}