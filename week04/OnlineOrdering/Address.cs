class Address(string street, string city, string state, string country)
{
  private readonly string _street = street;
  private readonly string _state = state;
  private readonly string _city = city;
  private readonly string _country = country;

  public bool IsUSAAddress() => _country == "USA";

  public string GetAddress() => $"{_street},{_city},\n{_state},\n{_country}";


}