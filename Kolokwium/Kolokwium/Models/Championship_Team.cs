using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models
{
    public class Championship_Team
    {
        [Key]
        public int IdTeam { get; set; }
        public int IdChampionship { get; set; }
        public float Score { get; set; }
        public virtual Championship Championship { get; set; }
        public virtual Team Team { get; set; }
    }
}