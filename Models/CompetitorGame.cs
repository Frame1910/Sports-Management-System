using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsManagementSystem.Models
{
    public class CompetitorGame
    {
        public int GameId { get; set; }
        public int CompetitorId { get; set; }
        public Game Game { get; set; }
        public Competitor Competitor { get; set; }
    }
}
