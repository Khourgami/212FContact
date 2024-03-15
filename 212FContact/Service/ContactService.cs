using _212FContact.Data;
using _212FContact.Models;
using System.Collections.Generic;

namespace _212FContact.Service
{
    public class ContactService : IContactService
    {
        private readonly IContactProvider _contactProvider;

        public ContactService(IContactProvider contactProvider)
        {
            _contactProvider = contactProvider;
        }

        public void AddContact(Contact contact)
        {
            // Add any business logic here before calling the repository method
            _contactProvider.AddContact(contact);
        }

    }
}
