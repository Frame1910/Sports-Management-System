using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsManagementSystem.Models
{
    public class CompetitorGames
    {
        [Display(Name = "Competitor ID")]
        public int CompetitorId { get; set; }
        public virtual Competitor Competitor { get; set; }
        [Display(Name = "Game ID")]
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}
