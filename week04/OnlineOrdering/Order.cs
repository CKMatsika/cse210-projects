// Order.cs
using System;
using System.Collections.Generic;
using System.Text;

public class Order
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
        decimal totalProductsCost = 0;
        
        // Calculate sum of all product costs
        foreach (Product product in _products)
        {
            totalProductsCost += product.CalculateProductCost();
        }
        
        // Add shipping cost based on customer location
        decimal shippingCost = _customer.IsInUSA() ? 5 : 35;
        
        return totalProductsCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        packingLabel.AppendLine("PACKING LABEL:");
        
        foreach (Product product in _products)
        {
            packingLabel.AppendLine($"Product: {product.GetName()} (ID: {product.GetProductId()})");
        }
        
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder shippingLabel = new StringBuilder();
        shippingLabel.AppendLine("SHIPPING LABEL:");
        shippingLabel.AppendLine($"Customer: {_customer.GetName()}");
        shippingLabel.AppendLine("Address:");
        shippingLabel.AppendLine(_customer.GetAddress().GetFormattedAddress());
        
        return shippingLabel.ToString();
    }
}