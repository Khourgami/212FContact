using _212FContact.Data;
using _212FContact.Models;
using _212FContact.Service;
using Microsoft.AspNetCore.Mvc;

namespace _212FContact.Controllers
{
    public class ContactController : Controller
    {

        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.AddContact(contact);
                return RedirectToAction("Index");
            }
            ViewData["Errors"] = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToArray();
            return View(contact);
        }

        public IActionResult Index()
        {
            var contact = new Contact(); 
            return View(contact);
        }
    }
}
