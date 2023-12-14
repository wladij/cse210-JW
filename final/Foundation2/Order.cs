public class Order
{
    public List<Product> Products { get; private set; } = new List<Product>();
    public Customer Customer { get; private set; }

    public Order(Customer customer)
    {
        Customer = customer;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.CalculateTotalCost();
        }

       
        totalCost += Customer.IsUsResident() ? 5 : 35;

        return totalCost;
    }

    public string GetPackagingLabel()
    {
        
        string packagingLabel = $"Packaging Label\n";
        packagingLabel += $"Customer: {Customer.Name}\n";
        packagingLabel += $"Shipping Address:\n{Customer.Address.GetAddressString()}\n";
        packagingLabel += "Products:\n";

        foreach (var product in Products)
        {
            packagingLabel += $"  - {product.Name} (ID: {product.ProductId})\n";
        }

        packagingLabel += $"Total Cost: ${CalculateTotalCost():F2}";

        return packagingLabel;
    }

    public string GetShippingLabel()
    {
        
        string shippingLabel = $"Shipping Label\n";
        shippingLabel += $"Customer: {Customer.Name}\n";
        shippingLabel += $"Shipping Address:\n{Customer.Address.GetAddressString()}\n";
        shippingLabel += "Products:\n";

        foreach (var product in Products)
        {
            shippingLabel += $"  - {product.Name} (ID: {product.ProductId})\n";
        }

        return shippingLabel;
    }
}