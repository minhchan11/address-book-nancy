namespace AddressBook.Objects
{
  public class Detail
  {
    private string _phone;
    private string _email;
    private Address _address;

    public Detail(string phone, string email, Address address)
    {
      _phone = phone;
      _email = email;
      _address = address;
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

    public Address GetAddress()
    {
      return _address;
    }
    public void SetAddress(Address inputAddress)
    {
      _address = inputAddress;
    }
  }
}
