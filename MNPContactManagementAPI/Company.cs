using System.ComponentModel.DataAnnotations;
namespace MNPContactManagementAPI
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
    }
}
