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
      _instances.Add(this);
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

    public static List<Contact> GetList()
    {
      return _instances;
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId -1];
    }

    public static List<Contact> SearchList(string searchName)
    {
      List<Contact> searchResult = new List<Contact>{};
      foreach (Contact inputContact in _instances)
      {
        if (inputContact._name == searchName)
        {
          searchResult.Add(inputContact);
        }
        else
        {
          return null;
        }
      }
      return searchResult;
    }

    public static Contact SearchResult()
    {
      return _instances[0];
    }
    
    public static void ClearOne(int searchIdclear)
    {
      _instances.RemoveAt(searchIdclear-1);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
