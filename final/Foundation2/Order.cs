using System;
    class Order 
    {
    private List<Product> products;

    private Customer customer;

    public Order( Customer customer)
    {
        
        this.customer = customer;
       
    }
    public void AddProduct(Product product)
    { 
        products.Add(product);
    }
    public double GetTotalCost() {
        double totalCost = 0;
        foreach (Product product in products) {
            totalCost += product.GetPrice();
        }
        if (customer.IsInUSA()) {
            totalCost += 5;
        } else {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel() 
    {
        string packingLabel = "";
        foreach (Product product in products) 
        {
            packingLabel += product.GetName() + " (ID: " + product.GetId() + ")\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        Customer customer = this.customer;
        string shippingLabel = customer.GetName() + "\n" + customer.GetAddress().GetAddressString();
        return shippingLabel;
    }
  }
 
 
