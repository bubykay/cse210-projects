using System.Text;

class Order
{
  private readonly Customer _customer;
  private readonly List<Product> _products = [];

  public Order(Customer customer)
  {
    _customer = customer;
  }

  public void AddProduct(string name, int id, decimal amount, int quantity)
  {
    _products.Add(new Product(name, id, amount, quantity));
  }

  public decimal OrderCost() => _products.Aggregate(0m, (acc, product) => acc + product.TotalCost());

  public string PackagingLabel() => string.Join("\n", _products);

  public string ShippingLabel() => $"{_customer.CustomerName()}\n{_customer.ShippingAddress()}";

  public decimal TotalCost() => _customer.IsUSAAddress() ? OrderCost() + 5 : OrderCost() + 35;

}