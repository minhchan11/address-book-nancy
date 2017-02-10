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
      _id = idCounter;
      idCounter++;
      _instances.add(This);
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string inputName)
    {
      _name = inputName;
    }

    public int GetId()
    {
      return _id;
    }
    public void SetId(int inputId)
    {
      _id = inputId;
    }

    public Detail GetDetail()
    {
      return _detail;
    }
    public void SetDetail(Detail inputDetail)
    {
      _detail = inputDetail;
    }
  }
}
