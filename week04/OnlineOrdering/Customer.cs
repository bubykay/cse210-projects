class Customer(string name, Address address)
{
  private readonly Address _address = address;
  private readonly string _name = name;

  public string ShippingAddress() => $"{_address.GetAddress()}";

  public bool IsUSAAddress() => _address.IsUSAAddress();

  public string GetAddress() => _address.GetAddress();

  public string CustomerName() => _name;

}