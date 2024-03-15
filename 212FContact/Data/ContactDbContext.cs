using _212FContact.Models;
using Microsoft.EntityFrameworkCore;

namespace _212FContact.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
