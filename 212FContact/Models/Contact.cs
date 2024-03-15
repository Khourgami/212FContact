using System.ComponentModel.DataAnnotations;

namespace _212FContact.Models
{
    public class Contact
    {
        [Key] 
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
    }
}
