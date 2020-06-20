using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.DTOs
{
    public class GetTeamsResponse
    {
        public int IdChampionship { get; set; }
        public Dictionary<string, float> Score { get; internal set; }
    }
}
