namespace AddressBook.Objects
{
  public class Detail
  {
    private string _address;
    private string _phoneNumber;
    private string _email;

    public Detail(string address, string phoneNumber, string email)
    {
      _address = address;
      _phoneNumber = phoneNumber;
      _email = email;
    }

    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string inputAddress)
    {
      _address = inputAddress;
    }
  }
}
