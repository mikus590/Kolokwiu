using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Team
    {
        [Key]
        public int IdTeam { get; set; }
        public string TeamName { get; set; }
        public int MaxAge { get; set; }
        public ICollection<Player_Team> Player_Teams { get; set; }
        public ICollection<Championship_Team> Championship_Teams { get; set; }
    }
}
