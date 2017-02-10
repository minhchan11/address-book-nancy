namespace AddressBook.Objects
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;

    public Address (string street, string city, string state)
    {
      _street = street;
      _city = city;
      _state = state;
    }

    public string GetStreet()
    {
      return _street;
    }
    public void SetStreet(string inputStreet)
    {
      _street = inputStreet;
    }

    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string inputCity)
    {
      _city = inputCity;
    }

    public string GetState()
    {
      return _state;
    }
    public void SetState(string inputState)
    {
      _state = inputState;
    }
  }
}
