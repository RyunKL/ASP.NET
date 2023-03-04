using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BakeryQT.Models
{
    public class Contact
    {
        [Key]
        [Range(0,10000, ErrorMessage ="Invalid ID, Must be minimum of 1, and can hold a max of 10,000")]
        public int ContactId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Organization { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Range(1,4, ErrorMessage ="Please select a valid category")]
        public int CategoryId { get; set; }
        public Categories? Category { get; set; }

        public string slug => FirstName?.Replace(" ", "-").ToLower() + "-" + LastName?.Replace(" ", "-").ToLower();

    }
}
