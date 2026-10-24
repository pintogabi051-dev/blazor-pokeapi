using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class GenerationViii
    {
        [JsonProperty("sword-shield")]
        public SwordShield swordshield { get; set; }

        [JsonProperty("legends-arceus")]
        public LegendsArceus legendsarceus { get; set; }

        [JsonProperty("brilliant-diamond-shining-pearl")]
        public BrilliantDiamondShiningPearl brilliantdiamondshiningpearl { get; set; }
    }
}