﻿using System.ComponentModel.DataAnnotations;

namespace _2ndChance.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required(ErrorMessage ="Please enter a valid first name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage ="Please enter a valid last name.")]
        public string? LastName { get; set; }
        [Required(ErrorMessage ="Please enter a valid phone number")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Please enter a valid email")]
        public string? Email { get; set; }
        public DateTime Date { get; set; }
        [Range(1,4,ErrorMessage ="Please select a valid category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string Slug => FirstName?.Replace(" ", "-").ToLower() + LastName?.Replace(" ", "-".ToLower());
    }
}
