using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models
{
    public class Championship
    {
        [Key]
        public int IdChampionship { get; set; }
        public string OfficialName { get; set; }
        public int Year { get; set; }
        public ICollection<Championship_Team> Championship_Teams { get; set; }
    }
}