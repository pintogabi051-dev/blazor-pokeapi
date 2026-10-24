using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class GenerationIi
    {
        [JsonProperty("gold-and-silver")]
        public GoldAndSilver goldandsilver { get; set; }
        public Gold gold { get; set; }
        public Silver silver { get; set; }
        public Crystal crystal { get; set; }
    }
}