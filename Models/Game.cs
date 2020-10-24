using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsManagementSystem.Models
{
    public class Game
    {
        [Display(Name = "Game ID")]
        [Key]
        public int GameId { get; set; }
        [Required] public string Code { get; set; }
        [Required] public string Name { get; set; }
        [Display(Name = "Duration (Hours)")]
        public int DurationInHours { get; set; }

        public string Description { get; set; }
        [Required] 
        [Display(Name = "Rules Booklet")]
        public string RulesBooklet { get; set; }
    }
}
