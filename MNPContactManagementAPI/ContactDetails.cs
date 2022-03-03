using System.ComponentModel.DataAnnotations;

namespace MNPContactManagementAPI
{
    public class ContactDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? LastDateContacted { get; set; } = DateTime.Now;
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string? Comments { get; set; }
    }
}
