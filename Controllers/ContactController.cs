using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AdressBook.Controllers
{
    public class ContactController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
          List<Contact> allContacts = Contact.GetAll();
          return View(allContacts);
        }

        [HttpGet("/new")]
        public ActionResult CreateForm()
        {
          return View();
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
          Contact newContact = new Contact (Request.Form["new-name"], Request.Form["new-address"], Request.Form["new-email"], Request.Form["new-number"]);
          newContact.Save();
          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);
        }

        [HttpPost("/delete")]
        public ActionResult DeleteAll()
        {
          Contact.ClearAll();
          return View();
        }
    }
}
