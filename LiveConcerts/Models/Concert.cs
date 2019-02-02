using System;
using System.ComponentModel.DataAnnotations;

namespace LiveConcerts.Models
{
    public class Concert
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; }

        public DateTime Datetime { get; set; }

        [Required]
        [MaxLength(255)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}