using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsManagementSystem.Models
{
    public class Event
    {
        [Display(Name = "Event ID")]
        [Key]
        public int EventId { get; set; }
        [Display(Name = "Featured Event")]
        public string FeatureEvent { get; set; }
        [Required] public string Venue { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }
        [Required] public string Description { get; set; }
        [Display(Name = "World Record")]
        public string WorldRecord { get; set; }

        // Navigation Properties
        [Display(Name = "Game ID")]
        [ForeignKey("Game")]
        public int GameId { get; set; }
        [Required] public virtual Game Game { get; set; }
    }
}
