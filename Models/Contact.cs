using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
    public class Contact
    {
      private string _name;
      private string _address;
      private string _email;
      private string _number; //Was recieving error that overflowed when exceeding 9 digits, so converted from int to string
      private static List<Contact> _instances = new List<Contact> {};

      public Contact ( string name, string address, string email, string number)
      {
        _name = name;
        _address = address;
        _email = email;
        _number = number;
      }

      public string GetName()
      {
        return _name;
      }

      public void SetName(string newName)
      {
        _name = newName;
      }
      public string GetAddress()
      {
        return _address;
      }
      public void SetAddress(string newAddress)
      {
        _address = newAddress;
      }
      public string GetEmail()
      {
        return _email;
      }
      public void SetEmail (string newEmail)
      {
        _email = newEmail;
      }
      public string GetNumber()
      {
        return _number;

      }
      public void SetNumber(string newNumber)
      {
        _number = newNumber;
      }
      public static List<Contact> GetAll()
      {
        return _instances;
      }
      public void Save()
      {
        _instances.Add(this);
      }
      public static void ClearAll()
      {
        _instances.Clear();
      }
    }
}
