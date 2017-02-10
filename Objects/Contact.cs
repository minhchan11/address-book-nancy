using System;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private int _id;
    private Detail _detail;

    private static List<Contact> _instances = new List<Contact>{};
    private static int idCounter = 1;

    public Contact (string name, Detail detail)
    {
      _name = name;
      _detail = detail;
    }
  }
}
