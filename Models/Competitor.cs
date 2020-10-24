using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace SportsManagementSystem.Models
{
    public class Competitor
    {
        [Display(Name = "Competitor ID")]
        [Key]
        public int CompetitorId { get; set; }
        public string Salutation { get; set; }
        [Required] public string Name { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Dob { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Description { get; set; }
        [Required] public string Country { get; set; }
        [Required] public string Gender { get; set; }
        [Display(Name = "Contact Number")]
        public string ContactNo { get; set; }

        public string Website { get; set; }
        public string Photo { get; set; }
    }
}
