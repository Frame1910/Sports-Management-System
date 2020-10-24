using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace SportsManagementSystem.Models
{
    public class EventOutcome
    {
        public string EventId { get; set; }
        public Event Event { get; set; }
        public string CompetitorId { get; set; }
        public Competitor Competitor { get; set; }
        [Required]
        public int Position { get; set; }
        public string Medal { get; set; }
    }
}
