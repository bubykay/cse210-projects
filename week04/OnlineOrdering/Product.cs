class Product(string name, int id, decimal amount, int quantity)
{
  private readonly int _id = id;
  private readonly decimal _amount = amount;
  private readonly string _name = name;
  private readonly int _quantity = quantity;

  public decimal TotalCost()
  {
    return _amount * _quantity;
  }
  public override string ToString()
  {
    return $"{_id} {_quantity} {_name} {_amount} {TotalCost():C}";
  }
}