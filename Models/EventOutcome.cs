using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace SportsManagementSystem.Models
{

    public class EventOutcome
    {
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
        [ForeignKey("Competitor")]
        [Display(Name = "Competitor ID")]
        public int CompetitorId { get; set; }
        public virtual Competitor Competitor { get; set; }
        [Required]
        public int Position { get; set; }

        public string Medal
        {
            get
            {
                if (Position == 1)
                {
                    return "Gold";
                }
                else if (Position == 2)
                {
                    return "Silver";
                }
                else if (Position == 3)
                {
                    return "Bronze";
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
