using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class GenerationVii
    {
        public Icons icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon ultrasunultramoon { get; set; }

        [JsonProperty("lets-go-pikachu-lets-go-eevee")]
        public LetsGoPikachuLetsGoEevee letsgopikachuletsgoeevee { get; set; }
    }
}