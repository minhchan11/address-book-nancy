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


  }
}
