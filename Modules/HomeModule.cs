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
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetList();
        return View["contacts.cshtml",allContacts];
      }
      Get["/contact_form"] = _ => View["contact_form.cshtml"];
      Post["/contacts"] = _ => {
        Address userAddress = new Address(Request.Form["street"], Request.Form["city"], Request.Form["state"]);
        Detail userDetail = new Detail(Request.Form["phone"], Request.Form["email"],userAddress);
        Contact userContact = new Contact(Request.Form["name"],userDetail);
        List<Contact> allContacts = Contact.GetList();
        return View["contacts.cshtml",allContacts];
      }
      Get["/contacts/{id}"] = parameters => {
        Contact userEntry = Contact.Find(parameters.id);
        return View["/contact.cshtml",userEntry];
      }
    }
  }
}
