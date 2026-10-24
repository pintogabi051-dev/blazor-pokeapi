using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class GenerationIv
    {
        public Icons icons { get; set; }
        public Platinum platinum { get; set; }

        [JsonProperty("diamond-pearl")]
        public DiamondPearl diamondpearl { get; set; }

        [JsonProperty("heartgold-soulsilver")]
        public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }
    }
}