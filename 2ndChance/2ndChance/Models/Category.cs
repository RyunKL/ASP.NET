using System.ComponentModel.DataAnnotations;

namespace _2ndChance.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Name { get; set; }

    }
}