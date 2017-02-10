using Nancy;
using AddressBook.Objects;
using System;
using System.Collections.Generic;

namespace MyAddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
    }
  }
}
