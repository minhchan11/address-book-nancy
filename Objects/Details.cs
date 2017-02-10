namespace AddressBook.Objects
{
  public class Detail
  {
    private Address _address;
    private string _phone;
    private string _email;

    public Detail(Address address, string phone, string email)
    {
      _address = address;
      _phone = phone;
      _email = email;
    }

    public Address GetAddress()
    {
      return _address;
    }
    public void SetAddress(Address inputAddress)
    {
      _address = inputAddress;
    }

    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string inputPhone)
    {
      _phone = inputPhone;
    }

    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string inputEmail)
    {
      return _email = inputEmail;
    }
  }
}
