using _212FContact.Models;

namespace _212FContact.Data
{
    public class EFContactProvider : IContactProvider
    {
        private readonly ContactDbContext _context;

        public EFContactProvider(ContactDbContext context)
        {
            _context = context;
        }

        public void AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }
    }
}
