using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsManagementSystem.Models
{
    public class EventPhoto
    {
        [Display(Name = "Photo ID")]
        [Key]
        public int PhotoId { get; set; }
        [Required]
        public string Photo { get; set; }
        public string PhotoTags { get; set; }
        // Navigation Properties
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
