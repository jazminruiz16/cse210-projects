/*Contains a list of products and a customer. 
Can calculate the total cost of the order. 
Can return a string for the packing label. 
Can return a string for the shipping label.
The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.

This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. 
If the customer does not live in the USA, then the shipping cost is $35.
Display:
A packing label should list the name and product id of each product in the order.
A shipping label should list the name and address of the customer*/
using System.Collections.Generic;
public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    /* public List<Product> GetList()
     {
         return _products;
     }*/
    public double GetTotalCost()
    {
        double total = 0;
        if (_customer.LivesInUSA() == true)
        {
            total = 5;
        }
        else
        {
            total = 35;
        }
        foreach (Product p in _products)
        {
            double costPerProduct = p.GetCostPerProduct();
            total = total + costPerProduct;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string allPackingLabel = "Packing Label: ";
        foreach (Product p in _products)
        {
            string packingLabel = "\n Product ID: " + p.GetId() + " Product: " + p.GetName() + " Quantity: " + p.GetQuantity();
            allPackingLabel = allPackingLabel + packingLabel;
        }
        return allPackingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label: \n Name: " + _customer.GetName() + "\n Address: " + _customer.GetAddress();
        return shippingLabel;
    }







}